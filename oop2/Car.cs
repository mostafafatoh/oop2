using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Car
    {
      public double Price;
      private string number;
        void moveforward()
        {
            number="123 ";
            Price=10;
        }
        public void SetPrice(double price)
        {
            if (price >= 5000)
            {
                Price = price;
            }
            else
            {
                Price = 5000;
            }
        }public double GetPrice()
        {
            return Price;   
        }
        void stop()
        {

        }


    }
}
