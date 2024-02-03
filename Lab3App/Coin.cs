﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin: Treasure
    {
        public int Value;

        public void UpdateTotalValue() 
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        public Coin(string description, int score, int value) : base(description, score) 
        {
            Value = value;
        }
        
    }
}
