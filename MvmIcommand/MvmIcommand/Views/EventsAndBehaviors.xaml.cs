using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvmIcommand.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsAndBehaviors : ContentPage
    {
        public EventsAndBehaviors()
        {
            InitializeComponent();
        }

        private void Sign(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.Clicked += DisplayActionsheetMethod;
            
            
        }
        public void DisplayActionsheetMethod(object sender, EventArgs e)
        {
            var btn = (Button)sender;
             DisplayActionSheet(btn.Text, "Cancel", "Delete", "Add New", "Save", "Edit", "Send");
        }

        
    }
}