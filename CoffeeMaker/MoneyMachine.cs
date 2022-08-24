using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class MoneyMachine
    {
        public double Profit { get; set; }
        public static double MoneyReceived { get; set; }
        private static string currency = "$";
        private static Dictionary<string, double> coinValues = new Dictionary<string, double>()
            {
               { "quarters", 0.25 },
               { "dimes", 0.10 },
               { "nickles", 0.05 },
               { "pennies", 0.01 },
            };
        public MoneyMachine()
        {
            Profit = 0;
            MoneyReceived = 0;
        }
        private static double ProcessCoins()
        {
            foreach (KeyValuePair<string, double> coin in coinValues)
            {
                bool repeat = true;
                while (repeat)
                {
                    Console.Write($"How many {coin.Key}: ");
                    string userCoins = Console.ReadLine();
                    bool isNumber = Double.TryParse(userCoins, out double coinCount);
                    if (isNumber)
                    {
                        MoneyReceived += coin.Value * coinCount;
                        repeat = false;
                    }
                }
            }
            return MoneyReceived;
        }

        public virtual bool MakePayment(double cost)
        {
            ProcessCoins();
            if(MoneyReceived >=  cost)
            {
                double change = MoneyReceived - cost;
                Console.WriteLine($"Here is {currency}{change} in change.");
                Profit += cost;
                MoneyReceived = 0;
                return true;

            }
            else
            {
                Console.WriteLine($"Sorry that's not enough money. {currency}{MoneyReceived} refunded.");
                MoneyReceived = 0;
                return false;
            }
        }
    }
}
