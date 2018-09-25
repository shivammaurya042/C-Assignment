using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("" +
                "Shanti Sagar", 
                new SouthIndianItem("Coffee", 10 ),
                new SouthIndianItem("Poori", 30 ),
                new ChineseItem("Veg Momos", 60 )
            );

            int i = 0;
            Console.WriteLine("MENU OF {0}", restaurant.Name);
            foreach (IMenuItem item in restaurant.TheMenu)
            {
                Console.WriteLine("{0} {1, -20} {2,10:C}", ++i, item.ItemName, item.Price);
            }
        }
    }
}
