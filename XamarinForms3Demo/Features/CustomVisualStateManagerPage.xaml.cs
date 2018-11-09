using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace XamarinForms3Demo.Features
{
    public partial class CustomVisualStateManagerPage : ContentPage
    {
        public CustomVisualStateManagerPage()
        {
            InitializeComponent();

        }


        void OnTextChanged(object sender, TextChangedEventArgs args)
        {
            bool isValid = Regex.IsMatch(args.NewTextValue, @"^[2-9]\d{2}-\d{3}-\d{4}$");
            GoToState(isValid);
        }

        void GoToState(bool isValid)
        {
            string visualState = isValid ? "Valid" : "Invalid";
            VisualStateManager.GoToState(helpLabel, visualState);
            VisualStateManager.GoToState(submitButton, visualState);
        }
    }
}
