using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Circle: ICalculate //Calculate
    {
        private int radius;
        public Circle(int r)
        {
            this.radius = r;
        }
        //override public int Area () --this is for inheritance using abstract class
        public int Area()
        {
            return (int)(3.14 * this.radius * this.radius);
        }
        //override public int Perimeter() --this is for inheritance using abstract class
        public int Perimeter()
        {
            return (int)(2 * 3.14 * this.radius);
        }
    }
}
