using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvmIcommand.ViewModels.Commands
{
    class RefrechListViewInteractivityCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ListViewInteractivityVM ListViewInteractivityVM { get; set; }
        public RefrechListViewInteractivityCommand(ListViewInteractivityVM listViewInteractivityVM)
        {
            ListViewInteractivityVM = listViewInteractivityVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ListViewInteractivityVM.RefreshList();
        }
    }
}
