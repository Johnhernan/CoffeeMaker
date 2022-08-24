using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            CoffeeMaker coffeeMaker = new CoffeeMaker();
            MoneyMachine moneyMachine = new MoneyMachine();


        bool appRunning = true;

            while (appRunning)
            {
                //{ menu.GetItems()}
                Console.WriteLine($"What would you like?: {menu.GetItems()}");
                string userInput = Console.ReadLine();
                if (userInput == "report")
                {
                    coffeeMaker.Report();
                }
                if(userInput != "exit")
                {
                    MenuItem drink = menu.FindDrink(userInput);
                    
                    if (drink != null)
                    {
                        bool paymentSuccessfull = moneyMachine.MakePayment(drink.Cost);
                        if (paymentSuccessfull)
                        {
                            bool enoughResources = coffeeMaker.SufficientResources(drink.Ingredients);
                            if (enoughResources)
                            {
                                coffeeMaker.MakeCoffee(drink.Name);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Drink choice is not valid");
                    }
                }
            }
        }
    }
}
