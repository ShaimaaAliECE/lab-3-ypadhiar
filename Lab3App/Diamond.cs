using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond: Treasure
    {
        public override void Display()
        {
            Console.WriteLine("Diamond " + Description + " is displayed");
        }

        public Diamond(string description, int score) : base(description, score) { }
        
    }
}
