using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe: Tool
    {
        public override void Display()
        {
            Console.WriteLine(String.Format("Axe {0} is displayed", Description));
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        public Axe(string description) : base(description) { } 
        
    }
}
