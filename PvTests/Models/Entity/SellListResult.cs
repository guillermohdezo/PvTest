using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.Models.Entity
{
    public class SellListResult
    {
        public int SellId { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
