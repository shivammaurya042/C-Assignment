using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Rectangle: ICalculate //Calculate
    {
        private int length;
        private int breadth;
        public Rectangle(int a,int b)
        {
            this.length = a;
            this.breadth = b;
        }
        //override public int Area () --this is for inheritance using abstract class
        public int Area()
        {
            return this.length * this.breadth;
        }
        //override public int Perimeter() --this is for inheritance using abstract class
        public int Perimeter()
        {
            return 2*(this.length + this.breadth);
        }
    }
}
