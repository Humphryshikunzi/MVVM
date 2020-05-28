using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvmIcommand.ViewModels;
using MvmIcommand.Models;

namespace MvmIcommand.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestNavPage : ContentPage
    {
        HomeVM vm;
        Client client;
      

        public TestNavPage()
        {
            InitializeComponent();
            vm = new HomeVM();
            BindingContext = vm;
            // Add XAML file
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            client = new Client();
            var allPersons = await  client.GetAllClients();
            ClientListView.ItemsSource = allPersons;
        }


        private async void Register_Clicked(object sender, EventArgs e)
        {
            client = new Client();
          await  client.AddClient(Email.Text, Password.Text);
             Email.Text = string.Empty;
             Password.Text = string.Empty;
            await DisplayAlert("Success", "Client Added Successfully", "OK");
            var allPersons = await client.GetAllClients();
             ClientListView.ItemsSource = allPersons;
        }

        private async void GetClientById_TextChanged(object sender, TextChangedEventArgs e)
        {

            client = new Client();
            try
            {
                var person = await client.GetClient(Convert.ToInt32(GetClientById.Text));
                if (person != null)
                {
                    GetClientById.Text = person.Id.ToString();
                    Email.Text = person.Email;
                    await DisplayAlert("Success", "Client Retrive Successfully", "OK");

                }
                else
                {
                    await DisplayAlert("Success", "No Client Available", "OK");
                }
            }
            catch (Exception)
            {
                await DisplayAlert("Error", "Enter valid client Id", "OK");

            }
           
        }

        private async void UpDateClient_Clicked(object sender, EventArgs e)
        {
            client = new Client();
            await  client.UpdateClient(Convert.ToInt32(GetClientById.Text),  Email.Text);
             Email.Text = string.Empty;
             Password.Text = string.Empty;
            await DisplayAlert("Success", "Client Updated Successfully", "OK");
            var allPersons = await  client.GetAllClients();
             ClientListView.ItemsSource = allPersons;
        }

        private async void DeleteClient_Clicked(object sender, EventArgs e)
        {
            client = new Client();
            await  client.DeleteClient(Convert.ToInt32( GetClientById.Text));
            await DisplayAlert("Success", "Client Deleted Successfully", "OK");
            var allPersons = await  client.GetAllClients();
             ClientListView.ItemsSource = allPersons;
        }
        // Navigate to forms page
        public void Navigate()
        {
           
        }
    }
}