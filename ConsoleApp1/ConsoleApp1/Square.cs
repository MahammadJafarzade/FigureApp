using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square : FIgure
    {
        public double side { get; set; }
        public Square(double side)
        {
            this.side = side;
        }
        public override double Area()
        {
            area = side * side;
            return area;
        }

        public override double Perimetr()
        {
            perimetr = 4 * side;
            return perimetr;
        }
    }
}
