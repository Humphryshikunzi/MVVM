using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvmIcommand.Models;
using MvmIcommand.ViewModels;
using Android.Widget;

namespace MvmIcommand.ViewModels.Commands
{
    class ICommandTwoCommand : ICommand
    {
        public  ICommandTwoViewModel  ICommandTwoViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public ICommandTwoCommand(ICommandTwoViewModel commandTwoViewModel)
        {
            ICommandTwoViewModel = commandTwoViewModel;
        }

        public bool CanExecute(object parameter)
        {
             var iCommandTwo = parameter as IcommandTwo;
             if (  iCommandTwo ==null)
             {
                 return false;
             }

             else if (string.IsNullOrWhiteSpace(iCommandTwo.Email) || string.IsNullOrWhiteSpace(iCommandTwo.Name))
             {
                  return false;
              }
             else
             {
                 return true;
             }
          
          
        }

        public void Execute(object parameter)
        {
            ICommandTwoViewModel.Register();
          
        }
    }
}
