using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvmIcommand.Models;

namespace MvmIcommand.ViewModels.Commands
{
     public   class NavigationCommand : ICommand
    {

        public  HomeVM  HomeVMModel { get; set; }

        public NavigationCommand(HomeVM homeVM)
        {
            HomeVMModel = homeVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           
            HomeVMModel.Navigate();
        }
    }
}
