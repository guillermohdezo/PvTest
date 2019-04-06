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

    }
}
