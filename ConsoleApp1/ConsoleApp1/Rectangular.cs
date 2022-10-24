using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangular : FIgure
    {

        public double a { get; set; }
        public double b { get; set; }
   
        public Rectangular(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            area = a * b;
            return area;
        }

        public override double Perimetr()
        {
            perimetr = 2*(a+b);
            return perimetr;
        }

        public override string ToString()
        {
            return "Rectangle Side 1:" +a+" Side 2: "+ b +" Area: "+ area + " Perimeter: " + perimetr;
        }
    }
}
