using System;
using System.Collections.Generic;
using System.Text;
using Android.Content.Res;
using MvmIcommand.ViewModels.Commands;
using MvmIcommand.Views;
using MvmIcommand.Models;
using System.ComponentModel;

namespace MvmIcommand.ViewModels
{
    public  class HomeVM 
    {
         TestLogIn NavCommand { get; set; }
        

        public HomeVM()
        {
            NavCommand = new TestLogIn(this);
        }
                 
        public async void Navigate()
        {
           await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
                             
        }
        public async void NavigateTestPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new   IcommandPage());

        }


    }
}
