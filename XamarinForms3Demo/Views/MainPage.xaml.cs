using XamarinForms3Demo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms3Demo.Features;

namespace XamarinForms3Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Invitation, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Invitation:
                        MenuPages.Add(id, new NavigationPage(new InvitationPage()));
                        break;
                    case (int)MenuItemType.FlexLayoutBasic:
                        MenuPages.Add(id, new NavigationPage(new FlexLayoutBasicPage()));
                        break;
                    case (int)MenuItemType.FlexLayoutAdvantage:
                        MenuPages.Add(id, new NavigationPage(new FlexLayoutAdvantage()));
                        break;
                    case (int)MenuItemType.StyleSheets:
                        MenuPages.Add(id, new NavigationPage(new StyleSheetsPage()));
                        break;
                    case (int)MenuItemType.VisualStateManager:
                        MenuPages.Add(id, new NavigationPage(new VisualStateManagerPage()));
                        break;
                    case (int)MenuItemType.CustomVisualStateManager:
                        MenuPages.Add(id, new NavigationPage(new CustomVisualStateManagerPage()));
                        break;
                    case (int)MenuItemType.AndroidBottonBar:
                        MenuPages.Add(id, new NavigationPage(new AndroidBottonBarPage()));
                        break;
                    case (int)MenuItemType.Forms31:
                        MenuPages.Add(id, new NavigationPage(new Forms31Page()));
                        break;
                    case (int)MenuItemType.Forms32:
                        MenuPages.Add(id, new NavigationPage(new Forms32Page()));
                        break;
                    case (int)MenuItemType.Forms33:
                        MenuPages.Add(id, new NavigationPage(new Forms33Page()));
                        break;
                    case (int)MenuItemType.Forms34:
                        MenuPages.Add(id, new NavigationPage(new Forms34Page()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}