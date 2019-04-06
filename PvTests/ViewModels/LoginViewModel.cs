using PvTests.Business.HttpRequest;
using PvTests.Models.BaseObject;
using PvTests.Models.Entity;
using PvTests.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PvTests.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        public LoginViewModel()
        {
            LoginCommand = new CommandBase(async e => await LoginProcess());
        }

        public Window View;

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }

        public CommandBase LoginCommand { get; set; }

        public async Task LoginProcess()
        {
            if (!string.IsNullOrEmpty(UserName))
            {
                LoginRequest request = new LoginRequest();
                LoginResponce loginResponce = new LoginResponce() { State = true, Type = "Admin" }; //await request.LoginCheck(UserName);
                if (loginResponce.State)
                {
                    View.Hide();
                    if (loginResponce.Type.Equals("Admin"))
                    {
                        AdminMenuView adminMenu = new AdminMenuView((View as Login).Windows);
                        adminMenu.Show();
                    }
                    else
                    {
                        UserMenuView userMenu = new UserMenuView((View as Login).Windows);
                        userMenu.Show();
                    }
                }
            }
        }
    }
}
