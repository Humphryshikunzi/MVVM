using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvmIcommand.Models;
using MvmIcommand.ViewModels;

namespace MvmIcommand.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class INotifyPage : ContentPage
    {
       // HomeVM vm;
        MainVm mainvm;
        public INotifyPage()
        {
            InitializeComponent();
           // vm = new HomeVM();
            mainvm = new MainVm();
           // BindingContext = vm;
            BindingContext = mainvm;
        }

    }
}