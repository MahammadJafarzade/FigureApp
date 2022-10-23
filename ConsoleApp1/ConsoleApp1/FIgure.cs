using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class FIgure
    {
        public abstract double Perimetr();
        public abstract double Area();
        public double area { get; set; }
        public double perimetr { get; set; }
        public List<Point> points { get; set; }
        public Point Center { get; protected set; }


    }
}
