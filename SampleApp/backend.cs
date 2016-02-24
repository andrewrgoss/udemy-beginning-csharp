using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Inventory
    {
        private object type = "vehicle";
        internal static int inventory = 100;
    }

    public class Vehicle
    {
        private int wheels = 4;
        private string color = "blue";
        private double price = 100.00;
        private string location = "saleswarehouse";

        public Vehicle(int wheels, string color)
        {
            this.wheels = wheels;
            this.color = color;
            if (wheels > 3) price = 1000.00;
        }

        public double FinalSalesPrice(int numVehicles)
        {
            if (Inventory.inventory > 0)
            {
                Inventory.inventory -= 1;
                return price * numVehicles * 1.06;
            }
        }

        public void Return(Vehicle somevehicle)
        {
            Inventory.inventory += 1;
            //total net income
            //totalnetincme - somevehicle.price;
            somevehicle.location = "return desk";
        }

        public void SetSalesDiscount(double disc)
        {
            if (disc >= 1)
            {
                throw new NotSupportedException("this isn't a charity, we dont' give things away for free");
            }
            price = price * (100 - disc);
        }

    }
}
