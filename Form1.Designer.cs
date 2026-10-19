namespace Lab6_25dh110311_NguyenAnhDuy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridProcesses = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.btnRunPriority = new System.Windows.Forms.Button();
            this.btnRunRR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPriorityAvgWait = new System.Windows.Forms.Label();
            this.lblPriorityAvgTurnaround = new System.Windows.Forms.Label();
            this.lblRRAvgWait = new System.Windows.Forms.Label();
            this.lblRRAvgTurnaround = new System.Windows.Forms.Label();
            this.listBoxGanttChart = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProcesses
            // 
            this.dataGridProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ArrivalTime,
            this.BurstTime,
            this.Priority});
            this.dataGridProcesses.Location = new System.Drawing.Point(12, 49);
            this.dataGridProcesses.Name = "dataGridProcesses";
            this.dataGridProcesses.Size = new System.Drawing.Size(515, 113);
            this.dataGridProcesses.TabIndex = 0;
            this.dataGridProcesses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Thời gian đến";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // BurstTime
            // 
            this.BurstTime.HeaderText = "Burst Time";
            this.BurstTime.Name = "BurstTime";
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Độ ưu tiên";
            this.Priority.Name = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantum:";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(70, 222);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(84, 20);
            this.txtQuantum.TabIndex = 2;
            // 
            // btnRunPriority
            // 
            this.btnRunPriority.Location = new System.Drawing.Point(177, 206);
            this.btnRunPriority.Name = "btnRunPriority";
            this.btnRunPriority.Size = new System.Drawing.Size(162, 58);
            this.btnRunPriority.TabIndex = 3;
            this.btnRunPriority.Text = "Chạy Priority";
            this.btnRunPriority.UseVisualStyleBackColor = true;
            this.btnRunPriority.Click += new System.EventHandler(this.btnRunPriority_Click);
            // 
            // btnRunRR
            // 
            this.btnRunRR.Location = new System.Drawing.Point(365, 206);
            this.btnRunRR.Name = "btnRunRR";
            this.btnRunRR.Size = new System.Drawing.Size(162, 58);
            this.btnRunRR.TabIndex = 4;
            this.btnRunRR.Text = "Chạy Round Robin";
            this.btnRunRR.UseVisualStyleBackColor = true;
            this.btnRunRR.Click += new System.EventHandler(this.btnRunRR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. Danh sách tiến trình";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2. Quantum và nút thực thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "3. Kết quả";
            // 
            // lblPriorityAvgWait
            // 
            this.lblPriorityAvgWait.AutoSize = true;
            this.lblPriorityAvgWait.Location = new System.Drawing.Point(82, 317);
            this.lblPriorityAvgWait.Name = "lblPriorityAvgWait";
            this.lblPriorityAvgWait.Size = new System.Drawing.Size(141, 13);
            this.lblPriorityAvgWait.TabIndex = 8;
            this.lblPriorityAvgWait.Text = "Priority - Thời gian chờ TB: --";
            // 
            // lblPriorityAvgTurnaround
            // 
            this.lblPriorityAvgTurnaround.AutoSize = true;
            this.lblPriorityAvgTurnaround.Location = new System.Drawing.Point(82, 340);
            this.lblPriorityAvgTurnaround.Name = "lblPriorityAvgTurnaround";
            this.lblPriorityAvgTurnaround.Size = new System.Drawing.Size(173, 13);
            this.lblPriorityAvgTurnaround.TabIndex = 9;
            this.lblPriorityAvgTurnaround.Text = "Priority - Thời gian quay vòng TB: --";
            this.lblPriorityAvgTurnaround.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblRRAvgWait
            // 
            this.lblRRAvgWait.AutoSize = true;
            this.lblRRAvgWait.Location = new System.Drawing.Point(82, 379);
            this.lblRRAvgWait.Name = "lblRRAvgWait";
            this.lblRRAvgWait.Size = new System.Drawing.Size(173, 13);
            this.lblRRAvgWait.TabIndex = 10;
            this.lblRRAvgWait.Text = "Round Robin - Thời gian chờ TB: --";
            // 
            // lblRRAvgTurnaround
            // 
            this.lblRRAvgTurnaround.AutoSize = true;
            this.lblRRAvgTurnaround.Location = new System.Drawing.Point(82, 402);
            this.lblRRAvgTurnaround.Name = "lblRRAvgTurnaround";
            this.lblRRAvgTurnaround.Size = new System.Drawing.Size(205, 13);
            this.lblRRAvgTurnaround.TabIndex = 11;
            this.lblRRAvgTurnaround.Text = "Round Robin - Thời gian quay vòng TB: --";
            // 
            // listBoxGanttChart
            // 
            this.listBoxGanttChart.FormattingEnabled = true;
            this.listBoxGanttChart.Location = new System.Drawing.Point(15, 460);
            this.listBoxGanttChart.Name = "listBoxGanttChart";
            this.listBoxGanttChart.Size = new System.Drawing.Size(512, 134);
            this.listBoxGanttChart.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 611);
            this.Controls.Add(this.listBoxGanttChart);
            this.Controls.Add(this.lblRRAvgTurnaround);
            this.Controls.Add(this.lblRRAvgWait);
            this.Controls.Add(this.lblPriorityAvgTurnaround);
            this.Controls.Add(this.lblPriorityAvgWait);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRunRR);
            this.Controls.Add(this.btnRunPriority);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProcesses);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Lab 6 - CPU Scheduling";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProcesses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Button btnRunPriority;
        private System.Windows.Forms.Button btnRunRR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPriorityAvgWait;
        private System.Windows.Forms.Label lblPriorityAvgTurnaround;
        private System.Windows.Forms.Label lblRRAvgWait;
        private System.Windows.Forms.Label lblRRAvgTurnaround;
        private System.Windows.Forms.ListBox listBoxGanttChart;
    }
}

