using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                string figuresInfo = "";
                List<FIgure> fIgures = new List<FIgure>();
                string folderName = @"C:\Users\Orkhan\OneDrive\Desktop\ConsoleApp\Figures.txt";
            while (true)
            {
                //Console application with menu:
                //1) show all figures
                //2) create a figure
                //3) change figure:
                //    a) move figure
                //    b) rotate figure
                //    c) scale figure
                //4)save to file
                //0) exit
                //While application is openings it's load data from file. 
                //figure should have info about their perimeter and area too.
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1) show all figures\n");
                Console.WriteLine("2) create a figure\n");
                Console.WriteLine("3) change figure:\n");
                Console.WriteLine("a) move figure\n");
                Console.WriteLine("b) rotate figure\n");
                Console.WriteLine("4)save to file\n");
                Console.WriteLine("0) exit");
                Console.Write("\nChoose from menu: ");
                string input = Console.ReadLine();


                if (input == "0")
                {
                    Environment.Exit(0);

                }
                if (input == "1")
                {
                    string[] lines = File.ReadAllLines(@"C:\Users\Orkhan\OneDrive\Desktop\ConsoleApp\Figures.txt");
                    foreach (var item in lines)
                    {
                        Console.WriteLine(item);
                        string[] words = item.Split(' ', ':');
                        foreach (var w in words) Console.WriteLine(w);
                    }
                }
                if (input == "2")
                {
                    Console.WriteLine("a) Square\n");
                    Console.WriteLine("b) rectangular\n");
                    Console.WriteLine("c) Triangle\n");
                    string options = Console.ReadLine();
                    switch (options)
                    {
                        case "a":
                            Console.Write("Enter side:");
                            double side = Convert.ToDouble(Console.ReadLine());
                            Square newSquare = new Square(side);
                            double area = newSquare.Area();
                            double perimetr = newSquare.Perimetr();
                            Console.WriteLine($"Area:{area}, Perimetr{perimetr}");

                            figuresInfo += $"Square Side: {side} Area: {area} Perimeter: {perimetr}";
                            break;
                        case "b":
                            Console.Write("Enter length:");
                            double length = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter height:");
                            double height = Convert.ToDouble(Console.ReadLine());
                            Rectangular newRectangular = new Rectangular(length, height);
                            double RectangularArea = newRectangular.Area();
                            double RectangularPerimetr = newRectangular.Perimetr();
                            Console.WriteLine($"Area:{RectangularArea}, Perimetr{RectangularPerimetr}");
                            fIgures.Add(newRectangular);
                            figuresInfo += newRectangular.ToString(); break;
                        case "c":
                            Console.Write("Enter a:");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter b:");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter c:");
                            double c = Convert.ToDouble(Console.ReadLine());
                            Triangle newTriangle = new Triangle(a, b, c);
                            double TriangleArea = newTriangle.Area();
                            double TrianglePerimetr = newTriangle.Perimetr();
                            Console.WriteLine($"Area:{TriangleArea}, Perimetr{TrianglePerimetr}");
                            figuresInfo += $"\nTriangle\nSide 1: {a}\nSide 2: {b}\nSide 3: {c}\nArea: {TriangleArea}\nPerimeter: {TrianglePerimetr}\n"; break;
                        default:
                            break;
                    }
                }
                if (input == "3")
                {

                }
                if (input == "4")
                {
                    using (StreamWriter writer = new StreamWriter(folderName, false))
                    {
                        foreach(var f in fIgures)
                        writer.WriteLine(f.ToString());
                    }
                    break;
                }
            }
        }
    }
}
