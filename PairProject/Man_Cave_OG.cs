using System;
using System.Collections.Generic;
using System.Text;

namespace PairProject
{
    public class Man_Cave_OG 
    {
        private readonly INacho_Cheese_Machine _CheeseMeiser; 
        IBig_Screen TheBigOne { get; set; }
        IArcade_Machine AllInOne { get; set; }

        public void WhatChannel()
        {
            Console.WriteLine(  "Yo, What channel you want?");
            TheBigOne.ChangeChannel(new Channel(int.Parse(Console.ReadLine())));


        }

        public Man_Cave_OG(INacho_Cheese_Machine cheeseMeiser)
        {
            _CheeseMeiser = cheeseMeiser;
        }

    }
}
