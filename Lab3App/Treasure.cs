﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure: Collectable
    {
        public int Score;

        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine("Total Score us updated to: " + Board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }
}
