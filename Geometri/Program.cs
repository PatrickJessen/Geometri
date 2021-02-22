using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            Console.WriteLine(square.CalculateCircumference());
            Console.WriteLine(square.CalculateArial());
            Square square1 = new Square();
            square1.Side = 40;

            Console.WriteLine(square1.CalculateCircumference());
            Console.WriteLine(square1.CalculateArial());
            Console.ReadKey();
        }
    }
}
