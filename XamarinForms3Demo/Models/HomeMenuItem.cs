using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms3Demo.Models
{
    public enum MenuItemType
    {
        Invitation,
        FlexLayoutBasic,
        FlexLayoutAdvantage,
        StyleSheets,
        VisualStateManager,
        CustomVisualStateManager,
        AndroidBottonBar,
        Forms31,
        Forms32,
        Forms33,
        Forms34

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
