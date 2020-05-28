using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvmIcommand.ViewModels.Commands
{
    class SignInCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        StudyCaseVM StudyCaseViewModel { get; set; }
        public SignInCommand(StudyCaseVM studyCaseViewModel)
        {
            StudyCaseViewModel = studyCaseViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StudyCaseViewModel.SignIn(null,null);
        }
    }
}
