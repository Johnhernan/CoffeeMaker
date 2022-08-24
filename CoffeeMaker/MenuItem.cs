using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class MenuItem
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }

        public MenuItem(string name, double cost, int water, int milk, int coffee)
        {
            Name = name;
            Cost = cost;
            Ingredients = new Dictionary<string, int>() {
                {"water", water },
                {"coffee", coffee },
                {"milk", milk }
            };
        }
    }
}
