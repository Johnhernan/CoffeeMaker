using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class Menu 
    {
        public MenuItem[] CoffeeMenu = new MenuItem[3] { 
            new MenuItem("latte", 2.5, 200, 150, 24),
            new MenuItem("espresso", 1.5, 50, 0, 18),
            new MenuItem("cappuccino", 3 ,  250, 50, 24)
        };


        public virtual string GetItems()
        {
            string options = "";
            foreach(MenuItem item in CoffeeMenu)
            {
                options += $"{item.Name} ";
            }
            return options;
        }
        public virtual MenuItem FindDrink(string order)
        {
            foreach(MenuItem item in CoffeeMenu)
            {
                if (item.Name == order)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
