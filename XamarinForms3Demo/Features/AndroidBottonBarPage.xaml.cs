using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace XamarinForms3Demo.Features
{
    public partial class AndroidBottonBarPage : Xamarin.Forms.TabbedPage
    {
        public AndroidBottonBarPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}
