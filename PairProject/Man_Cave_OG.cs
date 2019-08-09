using System;
using System.Collections.Generic;
using System.Text;

namespace PairProject
{
    public class Man_Cave_OG
    {
        private readonly INacho_Cheese_Machine _CheeseMeiser;
        private readonly IBig_Screen _TheBigOne;
        private readonly IArcade_Machine _AllInOne;




        public Man_Cave_OG(INacho_Cheese_Machine cheeseMeiser, IBig_Screen theBigOne, IArcade_Machine allInOne)
        {
            _CheeseMeiser = cheeseMeiser;

            _TheBigOne = theBigOne;

            _AllInOne = allInOne;
        }

        public Man_Cave_OG()
        {

        }



        public void HaveAGooodTime()
        {
            Console.WriteLine("Do you want chhese on the fries?");

            Cheese cheese = new Cheese(true);
            if (Console.ReadLine() == "yes")
            {
                cheese.IsPressing = true;
                _CheeseMeiser.GetCheese(cheese);
            }
            else
            {
                cheese.IsPressing = false;
                _CheeseMeiser.GetCheese(cheese);
            }

            Console.WriteLine("What channele do you want to watch? [integer]");

            Channel channelNum = new Channel(int.Parse(Console.ReadLine()));

            _TheBigOne.ChangeChannel(channelNum);


            string select = _AllInOne.UserSelection();

            Game gameName = new Game(select);
            _AllInOne.GameSelectoion(gameName);


        }



    }
}