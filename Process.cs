using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_25dh110311_NguyenAnhDuy
{
    public class Process
    {
        public string ID { get; set; }   // Ví dụ: P1, P2

        public int ArrivalTime { get; set; }    // Thời gian đến (Giả sử 0 cho đơn giản) 

        public int BurstTime { get; set; }   // Thời gian thực thi cần thiết

        public int Priority { get; set; }   // Độ ưu tiên (Số nhỏ hơn là ưu tiên cao hơn)

        // Dùng cho thuật toán Round Robin
        public int RemainingTime { get; set; }    // Thời gian thực thi còn lại

        public int CompletionTime { get; set; }  // Thời gian hoàn thành 

        public int TurnaroundTime { get; set; } // Thời gian quay vòng (Completion - Arrival)

        public int WaitingTime { get; set; }   // Thời gian chờ đợi (Turnaround - Burst)

        // Phương thức Clone để đảm bảo mỗi thuật toán chạy trên một bản sao dữ liệu SẠCh
        
        public Process Clone()
        {
            Process clone = (Process)this.MemberwiseClone();

            clone.RemainingTime = this.BurstTime;

            return clone;
        }
    }

}
