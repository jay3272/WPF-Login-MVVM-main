using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_LoginForm.Repositories;
using WPF_LoginForm.Views;

namespace WPF_LoginForm.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {

        //-> Commands
        public ICommand LogoutCommand { get; }

        public DashboardViewModel()
        {
            LogoutCommand = new ViewModelCommand(ExecuteLoginCommand);

        }

        private void ExecuteLoginCommand(object obj)
        {
            
        }

    }
}
