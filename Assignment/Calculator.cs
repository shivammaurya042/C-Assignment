using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Calculator
    {
        /// Version 4: Interface: Plug-And-Play code
        public void Area(ICalculate obj)
        {
            Console.WriteLine("Area using Interface");
            Console.WriteLine("Area is {0}", obj.Area());
        }
        public void Perimeter(ICalculate obj)
        {
            Console.WriteLine("Perimeter using Interface");
            Console.WriteLine("Perimeter is {0}", obj.Perimeter());
        }
    }

    /*
    /// <summary>
    /// Version 3: By Inheritance
    /// </summary>
    class Calculator
    {
        public void Area(Calculate o)
        {
            Console.WriteLine("Area using Inheritance");
            Console.WriteLine("Area is {0}",o.Area());
        }
        public void Perimeter(Calculate o)
        {
            Console.WriteLine("Perimeter using Inheritance");
            Console.WriteLine("Perimeter is {0}",o.Perimeter());
        }
    }
    */


    /*
    * VERSION 2: By Boxing and Unboxing
   class Calculator
   {
       public void Area(object o)
       {
           Console.WriteLine("Area using Boxing and Unboxing");
           if(o is Square)
           {
               Console.WriteLine("Area of Square is {0}", (o as Square).Area());
           }
           else if (o is Rectangle)
           {
               Console.WriteLine("Area of Rectangle is {0}", (o as Rectangle).Area());
           }
           else if (o is Circle)
           {
               Console.WriteLine("Area of Circle is {0}", (o as Circle).Area());
           }
           else if (o is Triangle)
           {
               Console.WriteLine("Area of Triangle is {0}", (o as Triangle).Area());
           }
       }
       public void Perimeter(object o)
       {
           Console.WriteLine("Perimeter using Boxing and Unboxing");
           if (o is Square)
           {
               Console.WriteLine("Perimeter of Square is {0}", (o as Square).Perimeter());
           }
           else if (o is Rectangle)
           {
               Console.WriteLine("Perimeter of Rectangle is {0}", (o as Rectangle).Perimeter());
           }
           else if (o is Circle)
           {
               Console.WriteLine("Perimeter of Circle is {0}", (o as Circle).Perimeter());
           }
           else if (o is Triangle)
           {
               Console.WriteLine("Perimeter of Triangle is {0}", (o as Triangle).Perimeter());
           }
       }
   }
   */


    /*
    * VERSION 1: Overloaded Methods provide the functionality
    class Calculator
    {
        public void Area(Square obj)
        {
            Console.WriteLine("Area using Overloading");
            Console.WriteLine("Area of is {0} ",obj.Area());
        }
        public void Area(Rectangle obj)
        {
             Console.WriteLine("Area using Overloading");
            Console.WriteLine("Area is {0} ", obj.Area());
        }
        public void Area(Circle obj)
        {
             Console.WriteLine("Area using Overloading");
            Console.WriteLine("Area is {0} ", obj.Area());
        }
        public void Area(Triangle obj)
        {
            Console.WriteLine("Area using inheritance");
            Console.WriteLine("Area is {0} ", obj.Area());
        }
        public void Perimeter(Square obj)
        {
              Console.WriteLine("Perimeter using Overloading");
            Console.WriteLine("Perimter is {0} ", obj.Perimeter());
        }
        public void Perimeter(Rectangle obj)
        {
            Console.WriteLine("Perimeter using Overloading");
            Console.WriteLine("Perimter is {0} ", obj.Perimeter());
        }
        public void Perimeter(Circle obj)
        {
             Console.WriteLine("Perimeter using Overloading");
            Console.WriteLine("Perimter is {0} ", obj.Perimeter());
        }
        public void Perimeter(Triangle obj)
        {
             Console.WriteLine("Perimeter using Overloading");
            Console.WriteLine("Perimter is {0} ", obj.Perimeter());
        }
    }
    */
}
