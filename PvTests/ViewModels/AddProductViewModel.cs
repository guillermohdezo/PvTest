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
    public class AddProductViewModel : ObservableObject
    {
        public AddProductViewModel()
        {
            AddProductCommand = new CommandBase(async (e) => await AddProductProcess());
            GetDepCommand = new CommandBase(async (e) => await GetDepProcess());
            GetDepCommand.Execute(null);
        }

        public List<DepResponce> DepResponcesList { get; set; }

        private List<string> stringDepList;

        public List<string> StringDepList
        {
            get { return stringDepList; }
            set { stringDepList = value; OnPropertyChanged(); }
        }

        private string stringDep;

        public string StringDep
        {
            get { return stringDep; }
            set { stringDep = value; OnPropertyChanged(); }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public CommandBase AddProductCommand { get; set; }
        public CommandBase GetDepCommand { get; set; }

        public async Task AddProductProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            DepResponce depSelected = DepResponcesList.Where(e => e.Description.Equals(StringDep)).FirstOrDefault();
            await productRequest.AddProduct(new ProductModel() { DepartmentId = depSelected.DepId, Description = Description, Price = price });
        }

        public async Task GetDepProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            DepResponcesList = await productRequest.GetDep();
            StringDepList = DepResponcesList.Select(e => e.Description).ToList();
        }
    }
}
