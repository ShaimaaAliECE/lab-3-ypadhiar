using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description;

        public CollectionBoard Board;

        public abstract void Display();

        public Collectable(string description)
        {
            Description = description;
        }
  
        public virtual void AddMe(List<Collectable> list)
        {
            if (list.Contains(this))
            {
                list.Remove(this);
                Console.WriteLine($"{this.Description} was removed.");
            }
            else
            {
                list.Add(this);
                Console.WriteLine($"{this.Description} Collected, Congrats!!!!");
            }
        }
    }
}
