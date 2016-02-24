using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Containers
{
    class Sack : Bag //the container's bag base class handles adding and removing items. All of the other rules happen in the derived classes. This core code gets shared everywhere, only needs to be written one time. This is the power of inheritance mixed with polymorphism. 
    {
        public Sack(int capacity) : base(capacity) //chaining constructors to gain access (related to inheritance)
        {

        }
        
        public override void AddItem(Items.Item itemToAdd)
        {
            if (itemToAdd.Weight > 1)
            {
                Console.WriteLine("That item is too big for the sack");
            }
            else
            {
                base.AddItem(itemToAdd);
            }
        }
    }
}
