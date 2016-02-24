using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd;

namespace sampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Vehicle car = new Vehicle(2, "blue");
            car.SetSalesDiscount(.1);
            double p = car.FinalSalesPrice(2);

            Vehicle bike = new Vehicle(4, "black");
            double pp = bike.FinalSalesPrice(1);
            bike.Return(bike);
        }
    }

   
}
