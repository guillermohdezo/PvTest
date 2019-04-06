using PvTests.Models.BaseObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        public LoginViewModel()
        {
            LoginCommand = new CommandBase(e =>
            {
                UserName = "Hola";
            });
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }

        public CommandBase LoginCommand { get; set; }
    }
}
