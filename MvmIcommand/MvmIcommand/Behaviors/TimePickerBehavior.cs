using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MvmIcommand.ViewModels;

namespace MvmIcommand.Behaviors
{
    class TimePickerBehavior : Behavior<TimePicker>
    {
        StudyCaseVM StudyCaseVM = new StudyCaseVM();
        protected override void OnAttachedTo(TimePicker bindable)
        {
            bindable.PropertyChanged += BindableTime_Set;
            bindable.PropertyChanged += StudyCaseVM.SignIn;
        }

        private void BindableTime_Set(object sender, EventArgs e)
        {
            var time = (TimePicker)sender;
            var selectedtime = time.Time;
            var stringselectedtime = selectedtime.ToString();

        }

        protected override void OnDetachingFrom(TimePicker bindable)
        {
            bindable.PropertyChanged -= BindableTime_Set;
            bindable.PropertyChanged -= StudyCaseVM.SignIn;
        }
    }
}
