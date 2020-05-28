using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvmIcommand.Models;
using MvmIcommand.Views;

namespace MvmIcommand.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigateFromPage : ContentPage
    {
        Data _name;
        public NavigateFromPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _name = new Data();
            _name.FirstName = "Humphry";
            Navigation.PushAsync(new NavigateToPage("Humphry", EntryNmae.Text));
        }
    }
}