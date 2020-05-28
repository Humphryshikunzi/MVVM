using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MvmIcommand.ViewModels.Commands;
using MvmIcommand.Models;
using Xamarin.Forms;
using System.Linq;

namespace MvmIcommand.ViewModels
{
    class StudyCaseVM : INotifyPropertyChanged
    {
        public  SignInCommand  SignInCommand { get; set; }
        public Data Data { get; set; }
        public List<City>  Cities { get; set; }
        public StudyCaseVM()
        {
            SignInCommand = new SignInCommand(this);
            Data = new Data();
            Cities = GetCityList().OrderBy(t => t.CityName).ToList();
        }


        private  string  email;
        public  string  Email
        {
            get { return  email; }
            set 
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }


        private  string  password;       
        public  string  Password
        {
            get { return  password; }
            set 
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private  DateTime  date;
        public  DateTime  DueDate
        {
            get { return  date; }
            set
            {  
                date = value;
                OnPropertyChanged("DueDate");
            }
        }

        private  TimeSpan  time;

        public  TimeSpan  DueTime
        {
            get { return  time; }
            set 
            {
                time = value;
                OnPropertyChanged("DueTime");
            }
        }
        private  double  brightnessValue;
                    
        public  double  BrightnessValue
        {
            get { return  brightnessValue; }
            set 
            {  
                brightnessValue = value;
                OnPropertyChanged("BrightnessValue");
            }
        }

        private  Boolean  signedIn;

        public  Boolean  SignedIn
        {
            get { return  signedIn; }
            set 
            {  
                signedIn = value;
                OnPropertyChanged("SignedIn");
            }
        }
       

        private  City  _selectedCity;

        public  City  _SelectedCity
        {
            get { return  _selectedCity; }
            set
            {
                
                if(_selectedCity != value)
                {
                    _selectedCity = value;
                    OnPropertyChanged("_SelectedCity");
                    MyCity = "You selected " + _selectedCity.CityName + " as your city.";
                }

            }
        }

        private  string  myCity;

        public  string  MyCity
        {
            get { return  myCity; }
            set
            {
            if(myCity != value)
                {
                    myCity = value;
                    OnPropertyChanged("MyCity");
                }   
            }
        }

        public List<City> GetCityList()
        {
            var cities = new List<City>()
            {
                new City() { Id=1, CityName="Nairobi" },
                new City(){Id = 2, CityName = "Kisumu"},
                new City(){Id = 3, CityName = "Mombasa"},
                new City(){Id = 4, CityName="Nakuru"}
            };
            return cities;
        }
                                    
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void SignIn(object sender, EventArgs e)
        {
                     
            Data = new Data()
            {
                Email = Email,
                Password = Password,
                BrightnessValue = BrightnessValue, 
                DueDate =  DueDate,
                DueTime = DueTime,
                SignedIn = signedIn,
                City = MyCity
            };
               
        }

    }
}
