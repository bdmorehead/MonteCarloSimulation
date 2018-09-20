using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod_Pi_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many times will you run this function?");
            var timesToRunProgram = int.Parse(Console.ReadLine();

            Random random = new Random();
            double x = NextDouble(random[timesToRunProgram]);
            double y = r.NextDouble[timesToRunProgram];
        }
        struct Coords
        {
            double x;
            double y;

            public Coords(double x, double y)
            {
                double newx = x ;
                double newy = y;
            }
        }

        public double HyponteneuseOfTriangle(double newx, double newy)
        {
            double hypoteneuseValue = Math.Sqrt((newx * newx) + (newy * newy));

        }
    }  
}
