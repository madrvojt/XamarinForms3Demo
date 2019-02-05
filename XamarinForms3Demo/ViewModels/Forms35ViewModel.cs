using System;
using System.Collections.ObjectModel;
using XamarinForms3Demo.Models;

namespace XamarinForms3Demo.ViewModels
{
    public class Forms35ViewModel
    {
        public ObservableCollection<Item> Items { get; set; }


        public Forms35ViewModel()
        {
            Items = new ObservableCollection<Item>();

            for (int i = 0; i<10; i++)
            {
                Items.Add(new Item
                {
                    Name = i.ToString()
                });
            }
        }


    }
}
