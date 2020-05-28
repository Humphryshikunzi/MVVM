using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvmIcommand.Models;

namespace MvmIcommand.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigateToPage : ContentPage
    {
        
        public NavigateToPage(string name2, string name3)
        {
            InitializeComponent();
            var data = new Data();
            var name = data.FirstName;
            FirstNameLabel.Text =name3 +" "+ name2;
        }
    }
}