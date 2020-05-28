using MvmIcommand.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MvmIcommand.Behaviors
{
    class SliderBehavior : Behavior<Slider>
    {
        StudyCaseVM StudyCaseVM = new StudyCaseVM();
        protected override void OnAttachedTo(Slider bindable)
        {
            bindable.ValueChanged += BindableSliderValueChanged;
            bindable.ValueChanged += StudyCaseVM.SignIn;
        }
        protected override void OnDetachingFrom(Slider bindable)
        {
            bindable.ValueChanged -= BindableSliderValueChanged;
            bindable.ValueChanged -= StudyCaseVM.SignIn;
        }

        private void BindableSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = (Slider)sender;
            var slidervaule = slider.Value;
            var slidevalueadded = slidervaule + 20;
        }
    }
}
