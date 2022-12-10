using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    internal class ShoppingListItem
    {
        public string Name { get; set; }

        public ShoppingListItem(string name)
        {
            Name = name;
        }
    }
}
