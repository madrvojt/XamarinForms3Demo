using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms3Demo.Features
{
    public partial class EssentialsPage : ContentPage
    {
        public EssentialsPage()
        {
            InitializeComponent();

            Battery.Text = $"Battery status is {Xamarin.Essentials.Battery.ChargeLevel}";
            Device.Text = $"Device type is {Xamarin.Essentials.DeviceInfo.DeviceType}";
            Model.Text = $"Device platform {Xamarin.Essentials.DeviceInfo.Platform}";

        }
    }
}
