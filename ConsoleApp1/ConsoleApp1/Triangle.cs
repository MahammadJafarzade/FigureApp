using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : FIgure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle(double a, double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Area()
        {
                double s = (a + b + c) / 2;
                double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("The area is " + result);
                return area;
        }

        public override double Perimetr()
        {
            perimetr = a+b+c;
            return perimetr;
        }
    }
}
