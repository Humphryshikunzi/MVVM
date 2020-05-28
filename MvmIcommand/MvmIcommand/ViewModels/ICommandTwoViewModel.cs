using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MvmIcommand.ViewModels.Commands;
using MvmIcommand.Models;
using MvmIcommand.Views;
using Android.Widget;

namespace MvmIcommand.ViewModels
{
    class ICommandTwoViewModel : INotifyPropertyChanged
    {
        public ICommandTwoCommand ICommandTwoCommand { get; set; }
        public ICommandTwoViewModel()
        {
            ICommandTwoCommand = new ICommandTwoCommand(this);
            IcommandTwo = new IcommandTwo();
        }
        private  IcommandTwo  icommandTwo;

        public  IcommandTwo  IcommandTwo
        {
            get { return  icommandTwo; }
            set 
            {
                icommandTwo = value;
                OnPropertyChanged("IcommandTwo");
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
               IcommandTwo =  new IcommandTwo
                {
                    Name = this.Name,
                    Email = this.Email
                };
            }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
                IcommandTwo = new IcommandTwo
                {
                    Name = this.Name,
                    Email = this.Email
                };
            }
        }
        private string dateDue;

        public string DateDue
        {
            get { return dateDue; }
            set
            {
                dateDue = DateTime.Now.ToString();
                OnPropertyChanged("DateDue");

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public async void Register()
        {
            IcommandTwo = new IcommandTwo();
            if (IcommandTwo.CanRegister(IcommandTwo.Name,IcommandTwo.Email))
            {
                await App.Current.MainPage.Navigation.PushAsync(new AuthenticationPage());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Invalid", "Email and Name can't be null", "Oaky");
            }
            
        }                                     
              
               
    }
}
