using System;
using System.Collections.Generic;
using System.Text;

namespace PairProject
{
    public class Man_Cave_Cheezes : INacho_Cheese_Machine
    {
        
        //public Cheese WantSomeCheese()
        //{
        //    Console.WriteLine("Want some cheese?");
        //    string userInput = Console.ReadLine();
        //    if (userInput == "Yes")
        //    {
        //        Cheese userCheese = new Cheese(true);
        //        return userCheese;
        //    }
        //    else
        //    {
        //        Cheese userCheese = new Cheese(false);
        //        return userCheese;
        //    }

        //}

        public string GetCheese(Cheese cheese)
        {

            string cheeseMessage;

            if (cheese.IsPressing == true)
            {
                cheeseMessage = "Get Sauced";
            }
            else
            {
                cheeseMessage = "No sauce for you!";
            }

            return cheeseMessage; 
        }
    }
}
