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
    public partial class IcommandPage : ContentPage
    {
        Data data;
        HomeVM VM;
        public IcommandPage()
        {
            InitializeComponent();
            data = new Data();
            containerStackLayout.BindingContext = data;
            VM = new HomeVM();
            BindingContext = VM;
           
        }

      /*  private void Register_Clicked(object sender, EventArgs e)
        {
            data.Email = EmailEntry.Text;
            data.Password = PasswordEntry.Text;
            data.FirstName = FirstName.Text;

        }*/
    }
}