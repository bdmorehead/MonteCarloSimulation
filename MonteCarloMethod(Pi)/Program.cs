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
            int iterations = int.Parse(Console.ReadLine());

            var x = new double[iterations];
            var y = new double[iterations];
            Random random = new Random();

            for (int i = 0; i < iterations; i++)
            {
                x[i] = random.NextDouble();
                y[i] = random.NextDouble();
            }
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine("x: {0}, y: {1}", x[i], y[i]);
            }

        }
       //public double HyponteneuseOfTriangle(double x,double y)
       //{
       //     double output = Math.Sqrt((x * x) + (y * y));
       //     if (output <= 1)
       //     {
       //         output.
       //     }
       //  
       //}
    }  ////
}
//Answers
//1. To account for the rest of the circle.
//2. With increasing parameters you will get closer to Pi.
//3. If its truly random no.
//4.
//5. Monte Carlo method used to randomly figure out presidents terms.

