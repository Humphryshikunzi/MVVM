using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MvmIcommand.Models;
using MvmIcommand.ViewModels.Commands;
using MvmIcommand.Views;

namespace MvmIcommand.ViewModels
{
    public class MainVm  : INotifyPropertyChanged

    {
        public Login Login { get; set; }
        private Data data;

        public Data Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged("Data");
             }
        }

        public LoginCommand LoginCommand { get; set; }
        public MainVm()
        {
            Data = new Data();
            LoginCommand = new LoginCommand(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
                new Data
                {
                    Email = this.Email,
                    Password = this.Password
                };
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
                new Data()
                {
                    Email = this.Email,
                    Password = this.Password
                };
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
         
        public async void DataLogin()
        {
            data = new Data()
            {
                Email = Email,
                Password = Password
            };
            
            bool canLogin = Data.LogIn(Email, Password);
            if (canLogin)
                await App.Current.MainPage.Navigation.PushAsync(new TestNavPage());
            else
                await App.Current.MainPage.DisplayAlert("Error", "Email and Pasword can't be empty", "Okay");

            
        }
    }
}
