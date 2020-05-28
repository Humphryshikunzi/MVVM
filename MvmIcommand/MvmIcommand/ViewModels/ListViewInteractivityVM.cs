using MvmIcommand.Models;
using MvmIcommand.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace MvmIcommand.ViewModels
{
    class ListViewInteractivityVM : INotifyPropertyChanged
    {
        public RefrechListViewInteractivityCommand RefrechListViewInteractivityCommand { get; set; }
        public   IEnumerable<City>  Cities { get; set; }

        private  bool isRefreshing;

        public  bool IsRefreshing
        {
            get { return isRefreshing; }
            set 
            {
                isRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public ListViewInteractivityVM()
        {
            RefrechListViewInteractivityCommand = new RefrechListViewInteractivityCommand(this);
            Cities = TheCities();
            
        }
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void RefreshList()
        {

            TheCities();
            Thread.Sleep(500);
            IsRefreshing = false;
            
        }

        public IEnumerable<City> TheCities()
        {
            var cities = new List<City>
            {
                new City(){Id = 1, CityName = "Nairobi"},
                new City(){Id = 2, CityName = "Kisumu"},
                new City(){Id = 3, CityName = "Mombasa"},
                new City(){Id = 4, CityName = "Nakuru"},
                new City(){Id = 5, CityName = "Eldoret"}
            };
            return cities;
        }
    }
}
