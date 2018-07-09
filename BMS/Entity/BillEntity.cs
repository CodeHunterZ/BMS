using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMS.Entity
{
    public class Bill
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public int Status { get; set; }
        public string Phone { get; set; }

        public DateTime StarTime { get; set; }

        public int Deadline { get; set; }

        public decimal RealPayment { get; set; }

        public decimal EveryMonthPayment { get; set; }

        public decimal Balance { get; set; }

        public int PayType { get; set; }

        public string Note { get; set; }

        public int RecordStatus { get; set; }

        public DateTime RecordTime { get; set; }

    }
}
