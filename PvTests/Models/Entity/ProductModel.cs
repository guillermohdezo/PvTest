using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.Models.Entity
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DepartmentId { get; set; }
        public decimal Total { get; set; }
    }
}
