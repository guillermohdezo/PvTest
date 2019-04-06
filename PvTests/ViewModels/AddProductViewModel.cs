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

        private string StringDep;

        public string stringDep
        {
            get { return StringDep; }
            set { StringDep = value; OnPropertyChanged(); }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private decimal Price;

        public decimal price
        {
            get { return Price; }
            set { Price = value; }
        }

        public CommandBase AddProductCommand { get; set; }
        public CommandBase GetDepCommand { get; set; }

        public async Task AddProductProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            DepResponce depSelected = DepResponcesList.Where(e => e.Description.Equals(StringDep)).FirstOrDefault();
            await productRequest.AddProduct(new ProductModel() { DepartmentId = depSelected.DepId, Description = Description, Price = Price });
        }

        public async Task GetDepProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            DepResponcesList = new List<DepResponce>() { new DepResponce() { DepId = 1, Description = "Fruteria" } }; //await productRequest.GetDep();
            StringDepList = DepResponcesList.Select(e => e.Description).ToList();
        }
    }
}
