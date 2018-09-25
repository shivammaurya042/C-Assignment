using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Triangle: ICalculate //Calculate for inheritance using abstract class
    {
        private int sideA;
        private int sideB;
        private int sideC;

        public Triangle(int a,int b,int c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

        //override public int Area () --this is for inheritance using abstract class
        public int Area()
        {
          int  S = (this.sideA + this.sideB + this.sideC) / 2;
          int _area= (int)Math.Sqrt(S * (S - this.sideA) * (S - this.sideB) * (S - this.sideC));
          return _area;
        }
        //override public int Perimeter() --this is for inheritance using abstract class
        public int Perimeter()
        {
            return (this.sideA+this.sideB+this.sideC);
        }
    }
}
