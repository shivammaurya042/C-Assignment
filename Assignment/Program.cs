using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squareObj = new Square(5);
            Rectangle rectangleObj = new Rectangle(3,4);
            Triangle triangleObj = new Triangle(3,4,5);
            Circle circleObj = new Circle(7);
            Calculator objectC= new Calculator();

            objectC.Area(squareObj);
            objectC.Area(rectangleObj);
            objectC.Area(circleObj);
            objectC.Area(triangleObj);
            objectC.Perimeter(squareObj);
            objectC.Perimeter(rectangleObj);
            objectC.Perimeter(circleObj);
            objectC.Perimeter(triangleObj);
        }
    }
}
