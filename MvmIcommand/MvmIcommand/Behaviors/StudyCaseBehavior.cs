using System;
using Xamarin.Forms;
using MvmIcommand.ViewModels;

namespace MvmIcommand.Behaviors
{
    class StudyCaseBehavior : Behavior<DatePicker>
    {
        StudyCaseVM StudyCaseVM = new StudyCaseVM();
        protected override void OnAttachedTo(DatePicker bindable)
        {
            bindable.DateSelected += Bindable_DateSelected;
            bindable.DateSelected += StudyCaseVM.SignIn;

        }

       

        protected override void OnDetachingFrom(DatePicker  bindable)
        {
            bindable.DateSelected -= Bindable_DateSelected;
            bindable.DateSelected -= StudyCaseVM.SignIn;
        }

        private void Bindable_DateSelected(object sender, DateChangedEventArgs e)
        {
            var finallyhavedata = (DatePicker)sender;
            var date = finallyhavedata.Date;
            var stringdate = finallyhavedata.Date.ToString();
        }
    }
}
