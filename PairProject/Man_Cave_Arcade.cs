using System;
using System.Collections.Generic;
using System.Text;

namespace PairProject
{
    class Man_Cave_Arcade : IArcade_Machine
    {
        private string _userChoice;
        public void GameSelectoion(Game game)
        {
            //gameName = game;

            if (game.GameTitle == _userChoice)
            {
                Console.WriteLine($"Let's play {game.GameTitle}");
            }
            else
            {
                Console.WriteLine("Sorry that's not a choice.");
            }
        }

        public void UserSelection(string userChoice)
        {
            _userChoice = userChoice;
        }
    }
}
