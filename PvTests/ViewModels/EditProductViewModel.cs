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
    public class EditProductViewModel : ObservableObject
    {
        public EditProductViewModel()
        {
            GetProductCommand = new CommandBase(async e => await GetProductProcess());
            GetProductCommand.Execute(null);
            GetDepCommand = new CommandBase(async (e) => await GetDepProcess());
            GetDepCommand.Execute(null);
            EditProductCommand = new CommandBase(async (e) => await UpdateProducProcess());
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

        public ProductModel ProductModelSelected { get; set; }

        private List<ProductModel> productList;

        public List<ProductModel> ProductList
        {
            get { return productList; }
            set { productList = value; OnPropertyChanged(); }
        }

        private List<string> productStringList;

        public List<string> ProductStringList
        {
            get { return productStringList; }
            set { productStringList = value; OnPropertyChanged(); }
        }

        private string productSelected;

        public string ProductSelected
        {
            get { return productSelected; }
            set { productSelected = value; OnPropertyChanged(); SelectProduct(value); }
        }

        private void SelectProduct(string value)
        {
            ProductModelSelected = ProductList.Where(e => e.Description.Equals(value)).FirstOrDefault();
            Description = ProductModelSelected.Description;
            Price = ProductModelSelected.Price;
            var dep = DepResponcesList.Where(e => e.DepId == ProductModelSelected.DepartmentId).FirstOrDefault();
            StringDep = dep.Description;
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }
        
        public CommandBase GetProductCommand { get; set; }
        public CommandBase GetDepCommand { get; set; }
        public CommandBase EditProductCommand { get; set; }

        public async Task GetProductProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            ProductList = new List<ProductModel>() { new ProductModel() { DepartmentId = 1, Description = "Sopa", Price = 5, ProductId = 1 } }; //await productRequest.GetProduct();
            ProductStringList = ProductList.Select(e => e.Description).ToList();
        }

        public async Task GetDepProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            DepResponcesList = new List<DepResponce>() { new DepResponce() { DepId = 1, Description = "Fruteria" } }; //await productRequest.GetDep();
            StringDepList = DepResponcesList.Select(e => e.Description).ToList();
        }

        public async Task UpdateProducProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            ProductModel productModel = ProductList.Where(e => e.Description.Equals(ProductSelected)).FirstOrDefault();
            DepResponce depResponce = DepResponcesList.Where(e => e.Description.Equals(StringDep)).FirstOrDefault();
            await productRequest.EditProduct(new ProductModel() { DepartmentId = depResponce.DepId, Description = Description, Price = Price, ProductId = productModel.ProductId });
        }
    }
}
