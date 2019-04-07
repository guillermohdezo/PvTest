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
    public class SellViewModel : ObservableObject
    {
        public SellViewModel()
        {
            AddSellCommand = new CommandBase(e => AddSellProcess());
            SendSellCommand = new CommandBase(async e => await SendSellProcess());
            GetProductCommand = new CommandBase(async e => await GetProductProcess());
            GetProductCommand.Execute(null);
            SellList = new List<SubSellModel>();
            Quantity = 1;
        }

        public CommandBase AddSellCommand { get; set; }
        public CommandBase SendSellCommand { get; set; }
        public CommandBase GetProductCommand { get; set; }
        
        private List<ProductModel> productList;

        public List<ProductModel> ProductList
        {
            get { return productList; }
            set { productList = value; OnPropertyChanged(); }
        }

        private List<SubSellModel> sellList;

        public List<SubSellModel> SellList
        {
            get { return sellList; }
            set { sellList = value; OnPropertyChanged(); }
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
            set { productSelected = value; OnPropertyChanged(); }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private string totalString;

        public string TotalString
        {
            get { return totalString; }
            set { totalString = value; OnPropertyChanged(); }
        }

        decimal Total { get; set; }

        public async Task SendSellProcess()
        {
            SellRequest sellRequest = new SellRequest();
            var sellModel = new SellModel() { UserId = 1, SubSellList = SellList };
            var result = await sellRequest.AddSell(sellModel);
            SellList = new List<SubSellModel>();
            Total = 0;
        }

        public async Task GetProductProcess()
        {
            ProductRequest productRequest = new ProductRequest();
            ProductList = await productRequest.GetProduct();
            ProductStringList = ProductList.Select(e => e.Description).ToList();
        }

        public void AddSellProcess()
        {
            ProductModel product = ProductList.Where(e => e.Description.Equals(ProductSelected)).FirstOrDefault();
            decimal total = product.Price * Quantity;
            Total += total;
            TotalString = $"Total: {Total}";
            SellList.Add(new SubSellModel() { Description = product.Description, Quantity = Quantity, ProductId = product.ProductId, Total = total });
            SellList = SellList.ToList();
            ProductSelected = "";
            Quantity = 1;
        }
    }
}
