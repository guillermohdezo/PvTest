using PvTests.Business.HttpRequest;
using PvTests.Models.BaseObject;
using PvTests.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.ViewModels
{
    public class SellListViewModel : ObservableObject
    {
        public SellListViewModel()
        {
            GetSellListCommand = new CommandBase(async e => await GetSellListProcess());
            GetSellListCommand.Execute(null);
        }

        private List<SellListResult> sellList;

        public List<SellListResult> SellList
        {
            get { return sellList; }
            set { sellList = value; OnPropertyChanged(); }
        }

        CommandBase GetSellListCommand { get; set; }

        public async Task GetSellListProcess()
        {
            SellRequest request = new SellRequest();
            SellList = await request.GetSell();
        }
    }
}
