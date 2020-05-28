using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MvmIcommand.Models
{
    public class Data : INotifyPropertyChanged
    {
        
        private string  id;

        public string  Id
        {
            get { return  id; }
            set { 
                id = value;
                OnPropertyChanged("Id");
                }
            
        }
       

        private  string  firstName;

        public  string  FirstName
        {
            get { return  firstName; }
            set { 
                firstName = value;
                OnPropertyChanged("FirstName");
               
               }
        }


        private string  email;

        public  string  Email
        {
            get { return  email; }
            set { 
                email = value;
                OnPropertyChanged("Email");
               
            }
        }

        private string password;           
        public  string  Password
        {
            get { return  password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
               
            }

        }
        private   DateTime  dueDatePicker;

        public   DateTime DueDate
        {
            get { return  dueDatePicker; }
            set {  dueDatePicker = value; }
        }
        private   TimeSpan  dueTimePicker;

        public   TimeSpan DueTime
        {
            get { return  dueTimePicker; }
            set {  dueTimePicker = value; }
        }
        private  double  brightnessVaule;

        public  double BrightnessValue
        {
            get { return  brightnessVaule; }
            set {  brightnessVaule = value; }
        }
        private Boolean signedIn;

        public Boolean SignedIn
        {
            get { return signedIn; }
            set
            {
                signedIn = value;
                OnPropertyChanged("SignedIn");
            }
        }
        private  string  city;

        public  string  City
        {
            get { return  city; }
            set 
            {  
                city = value;
                OnPropertyChanged("City");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public  bool LogIn(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(password)) 
               return false;
            return true;
        }

    }
}

