using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.Models.Entity
{
    public class SellModel
    {
        public int UserId { get; set; }
        public List<SubSellModel> SubSellList { get; set; }
    }
}
