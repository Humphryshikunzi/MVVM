using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvmIcommand.Models
{
    class IcommandTwo : INotifyPropertyChanged
    {
        public int  Id { get; set; }
        private  string  name;

        public  string  Name
        {
            get { return  name; }
            set 
            {
                name = value;
                OnPropertyChanged("Name");
            }
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
        private  string  timeDue;

        public  string  TimeDue
        {
            get { return  timeDue; }
            set 
            {  timeDue = value;
                OnPropertyChanged("TimeDue");
            }
        }
        private  string  dateDue;

        public  string  DateDue
        {
            get { return  dateDue; }
            set 
            {  
                dateDue = DateTime.Now.ToString();
                OnPropertyChanged("DateDue");
            
            }
        }
        




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if ( PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool CanRegister(string name, string email)
        {
            if ( string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            return true;
        }


    }
}
