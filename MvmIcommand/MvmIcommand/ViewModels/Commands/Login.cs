using System;
using System.Collections.Generic;
using System.Text;
using MvmIcommand.Models;
using System.Windows.Input;


namespace MvmIcommand.ViewModels.Commands
{
     public class Login : ICommand
    {
        public HomeVM homeVM { get; set; }
        public Login(HomeVM homeVMmodel)
        {
            homeVM = homeVMmodel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var data = (Data)parameter;
            if (data==null)
                return false;
            else if (string.IsNullOrWhiteSpace(data.Email) || string.IsNullOrWhiteSpace(data.Password))
                return false;
            else
              return true;
        }

        public void Execute(object parameter)
        {
           // homeVM.LoginMethod();
        }
    }
}
