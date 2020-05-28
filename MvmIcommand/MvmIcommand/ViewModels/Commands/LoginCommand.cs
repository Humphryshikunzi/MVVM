using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvmIcommand.Models;

namespace MvmIcommand.ViewModels.Commands
{
    public class LoginCommand : ICommand
    {
        public MainVm ViewModel { get; set; }
        public LoginCommand(MainVm mainVm)
        {
            ViewModel = mainVm;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            /*var data = (Data)parameter;
            if ( data ==null)
            {
                return false;
            }
            if ( string.IsNullOrEmpty(data.Email)|| string.IsNullOrEmpty(data.Password))
            {
                return false;
            }*/
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.DataLogin();
        }
    }
}
