using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms3Demo.ViewModels;

namespace XamarinForms3Demo.Features
{
    public partial class Forms35Page : ContentPage
    {
        public Forms35Page()
        {
            InitializeComponent();
            BindingContext = new Forms35ViewModel();
        }
    }
}
