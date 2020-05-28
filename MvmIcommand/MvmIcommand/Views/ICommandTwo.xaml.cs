using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvmIcommand.ViewModels;

namespace MvmIcommand.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ICommandTwo : ContentPage
    {
        ICommandTwoViewModel commandTwoViewModel;
        public ICommandTwo()
        {
            InitializeComponent();
            commandTwoViewModel = new ICommandTwoViewModel();
            BindingContext = commandTwoViewModel;
        }
    }
}