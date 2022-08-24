using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class CoffeeMaker
    {   
        public static Dictionary<string, int> Ingredients { get; set; }
        public CoffeeMaker()
        {
            Ingredients = new Dictionary<string, int>() { { "water", 300}, { "milk", 200 }, { "coffee", 100 } };
        }
        public virtual void Report()
        {
            Console.WriteLine("The current ingredient stock: ");
            foreach(KeyValuePair<string, int> pair in Ingredients)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
        public virtual bool SufficientResources(Dictionary<string, int>ingredients)
        {
            foreach(KeyValuePair<string, int> pair in ingredients)
            {
                if(pair.Value <= Ingredients[pair.Key])
                {
                    Ingredients[pair.Key] -= pair.Value;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public virtual void MakeCoffee(string drink)
        {
            Console.WriteLine($"Here is your {drink}");
        }
    }
}
