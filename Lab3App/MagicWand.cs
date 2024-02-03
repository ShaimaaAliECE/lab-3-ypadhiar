using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand: Tool
    {
        public override void Display()
        {
            Console.WriteLine(String.Format("MagicWand {0} is displayed", Description));
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public MagicWand(string description) : base(description) { }
        
    }
}
