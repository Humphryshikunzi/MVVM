using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvmIcommand.ViewModels;

namespace MvmIcommand.ViewModels.Commands
{
    class TestLogIn : ICommand
    {
         HomeVM NavigationCommand { get; set; }
        public TestLogIn(HomeVM homeVM)
        {
            NavigationCommand = homeVM;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            NavigationCommand.NavigateTestPage();
        }
    }
}
