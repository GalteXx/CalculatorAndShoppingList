using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    internal class ShoppingListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ShoppingListItem> Items { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddItem => new Command<string>(NewItem);

        public ShoppingListViewModel()
        {
            Items = new();
        }

        private void NewItem(string ItemName)
        {
            Items.Add(new ShoppingListItem(ItemName));
        } 
        
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
