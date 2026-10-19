using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_25dh110311_NguyenAnhDuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
//==========================================================================================//
        private List<Process> GetProcessesFromGrid()
        {
            List<Process> processes = new List<Process>();

            foreach (DataGridViewRow row in dataGridProcesses.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string id = Convert.ToString(row.Cells[0].Value).Trim();
                string arrivalText = Convert.ToString(row.Cells[1].Value).Trim();
                string burstText = Convert.ToString(row.Cells[2].Value).Trim();
                string priorityText = Convert.ToString(row.Cells[3].Value).Trim();

                if (id == "" && arrivalText == "" &&
                    burstText == "" && priorityText == "")
                {
                    continue;
                }

                int arrival;
                int burst;
                int priority;

                if (id == "" ||
                    !int.TryParse(arrivalText, out arrival) ||
                    !int.TryParse(burstText, out burst) ||
                    !int.TryParse(priorityText, out priority))
                {
                    MessageBox.Show("Anh hãy kiểm tra lại dữ liệu trong bảng.");
                    return new List<Process>();
                }

                if (arrival < 0 || burst <= 0)
                {
                    MessageBox.Show(
                        "Thời gian đến không được âm và Burst Time phải lớn hơn 0."
                    );

                    return new List<Process>();
                }

                Process p = new Process();

                p.ID = id;
                p.ArrivalTime = arrival;
                p.BurstTime = burst;
                p.Priority = priority;
                p.RemainingTime = burst;

                processes.Add(p);
            }

            return processes;
        }
//============================================================================================//
        private void CalculateFinalMetrics(List<Process> processes)
        {
            foreach (Process p in processes)
            {
                p.TurnaroundTime = p.CompletionTime - p.ArrivalTime;

                p.WaitingTime = p.TurnaroundTime - p.BurstTime;
            }
        }
        //============================================================================================//
        private void DisplayResults(
           List<Process> processes,
           string algorithmName,
           Label lblWait,
           Label lblTurnaround)
        {
            if (processes.Count == 0)
            {
                return;
            }

            double avgWait = processes.Average(p => p.WaitingTime);

            double avgTurnaround =
                processes.Average(p => p.TurnaroundTime);

            lblWait.Text = "Thời gian chờ TB: " + avgWait.ToString("F2");

            lblTurnaround.Text =
                "Thời gian quay vòng TB: " + avgTurnaround.ToString("F2");
        }
        //==============================================================================================//
        private void LogGanttEntry(
    string processID,
    int startTime,
    int endTime)
        {
            listBoxGanttChart.Items.Add(
                "[" + startTime + "] -- " + processID + " --> [" + endTime + "]"
            );
        }
        //===============================================================================================//

        private void btnRunPriority_Click(object sender, EventArgs e)
        {
            List<Process> waiting = GetProcessesFromGrid();

            if (waiting.Count == 0)
            {
                return;
            }

            List<Process> completed = new List<Process>();

            listBoxGanttChart.Items.Clear();

            listBoxGanttChart.Items.Add(
                "--- Priority Non-preemptive ---"
            );

            int currentTime = 0;

            while (waiting.Count > 0)
            {
                List<Process> ready = waiting
                    .Where(p => p.ArrivalTime <= currentTime)
                    .OrderBy(p => p.Priority)
                    .ThenBy(p => p.ArrivalTime)
                    .ToList();

                if (ready.Count == 0)
                {
                    currentTime = waiting.Min(p => p.ArrivalTime);

                    continue;
                }

                Process current = ready[0];

                int startTime = currentTime;

                currentTime = currentTime + current.BurstTime;

                current.CompletionTime = currentTime;

                LogGanttEntry(
                    current.ID,
                    startTime,
                    current.CompletionTime
                );

                waiting.Remove(current);

                completed.Add(current);
            }

            CalculateFinalMetrics(completed);

            DisplayResults(
                completed,
                "Priority",
                lblPriorityAvgWait,
                lblPriorityAvgTurnaround
            );
        }

        //==========================================================================================//
        private void btnRunRR_Click(object sender, EventArgs e)
        {
            int quantum;

            if (!int.TryParse(txtQuantum.Text, out quantum) ||
                quantum <= 0)
            {
                MessageBox.Show("Quantum phải là số nguyên lớn hơn 0.");
                return;
            }

            List<Process> originalProcesses =
                GetProcessesFromGrid()
                .Select(p => p.Clone())
                .ToList();

            if (originalProcesses.Count == 0)
            {
                return;
            }

            List<Process> pendingProcesses = originalProcesses
                .OrderBy(p => p.ArrivalTime)
                .ToList();

            Queue<Process> readyQueue = new Queue<Process>();

            List<Process> completedProcesses = new List<Process>();

            listBoxGanttChart.Items.Clear();

            listBoxGanttChart.Items.Add(
                "--- Round Robin, Quantum = " + quantum + " ---"
            );

            int currentTime = 0;
            int nextProcessIndex = 0;

            while (completedProcesses.Count < originalProcesses.Count)
            {
                while (nextProcessIndex < pendingProcesses.Count &&
                       pendingProcesses[nextProcessIndex].ArrivalTime <= currentTime)
                {
                    readyQueue.Enqueue(pendingProcesses[nextProcessIndex]);

                    nextProcessIndex++;
                }

                if (readyQueue.Count == 0)
                {
                    if (nextProcessIndex < pendingProcesses.Count)
                    {
                        currentTime =
                            pendingProcesses[nextProcessIndex].ArrivalTime;

                        continue;
                    }

                    break;
                }

                Process currentProcess = readyQueue.Dequeue();

                int startTime = currentTime;

                int executionTime = Math.Min(
                    currentProcess.RemainingTime,
                    quantum
                );

                currentTime = currentTime + executionTime;

                currentProcess.RemainingTime =
                    currentProcess.RemainingTime - executionTime;

                LogGanttEntry(
                    currentProcess.ID,
                    startTime,
                    currentTime
                );

                while (nextProcessIndex < pendingProcesses.Count &&
                       pendingProcesses[nextProcessIndex].ArrivalTime <= currentTime)
                {
                    readyQueue.Enqueue(pendingProcesses[nextProcessIndex]);

                    nextProcessIndex++;
                }

                if (currentProcess.RemainingTime <= 0)
                {
                    currentProcess.CompletionTime = currentTime;

                    completedProcesses.Add(currentProcess);
                }
                else
                {
                    readyQueue.Enqueue(currentProcess);
                }
            }

            CalculateFinalMetrics(completedProcesses);

            DisplayResults(
                completedProcesses,
                "Round Robin",
                lblRRAvgWait,
                lblRRAvgTurnaround
            );
        }

        //==========================================================================================//
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
