using RPGInventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Containers
{
    class Bag : Item
    {
        protected int _capacity;
        protected int _currentIndex;
        protected Item[] _itemsInBag;

        public Bag(int capacity)
        {
            Name = "A small brown bag";
            Weight = 2;
            _itemsInBag = new Item[capacity];
            _capacity = capacity;
        }

        public virtual void AddItem(Item itemToAdd)
        {
            if (_currentIndex >= _capacity)
            {
                Console.WriteLine("The bag is full!");
            }
            else
            {
                _itemsInBag[_currentIndex] = itemToAdd;
                _currentIndex++;
            }
        }

        public virtual Item RemoveItem()
        {
            if (_currentIndex == 0)
            {
                Console.WriteLine("The bag is empty");
                return null;
            }
            else 
            {
                Item itemToReturn = _itemsInBag[_currentIndex-1];

                _itemsInBag[_currentIndex-1] = null;
                _currentIndex--;

                return itemToReturn;
            }
        }

        public virtual void DisplayContents()
        {
            Console.WriteLine("Items in bag: ");

            foreach (var item in _itemsInBag)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
