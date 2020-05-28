using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvmIcommand.Services;
using MvmIcommand.Views;

using MvmIcommand.Views.Forms;
namespace MvmIcommand
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new  ListViewInteractivity());
          
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
