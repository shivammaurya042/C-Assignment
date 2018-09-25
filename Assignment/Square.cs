using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Square: ICalculate //Calculate
    {
        private int side;
        public Square(int a)
        {
            this.side = a;
        }
        //override public int Area () --this is for inheritance using abstract class
        public int Area()
        {
            return this.side*this.side;
        }
        //override public int Perimeter() --this is for inheritance using abstract class
        public int Perimeter()
        {
            return 4*this.side;
        }
    }
}
