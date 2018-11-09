using XamarinForms3Demo.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms3Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Invitation, Title="Home Page" },
                new HomeMenuItem {Id = MenuItemType.FlexLayoutBasic, Title="Flex Layout Basic" },
                new HomeMenuItem {Id = MenuItemType.FlexLayoutAdvantage, Title="Flex Layout Advantage" },
                new HomeMenuItem {Id = MenuItemType.StyleSheets, Title="StyleSheets" },
                new HomeMenuItem {Id = MenuItemType.VisualStateManager, Title="VisualStateManager" },
                new HomeMenuItem {Id = MenuItemType.CustomVisualStateManager, Title="CustomVisualStateManager" },
                new HomeMenuItem {Id = MenuItemType.AndroidBottonBar, Title="Android BottonBar" },
                new HomeMenuItem {Id = MenuItemType.Forms31, Title="Other news from 3.1" },
                new HomeMenuItem {Id = MenuItemType.Forms32, Title="News from 3.2" },
                new HomeMenuItem {Id = MenuItemType.Forms33, Title="News from 3.3" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}