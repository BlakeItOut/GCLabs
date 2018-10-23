using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("Welcome to the Circle Tester");
            while (true)
            {
                double radius = double.Parse(Validator.promptUser("Enter Radius: ", (num => double.TryParse(num, out radius) && radius > 0)));
                counter++;
                Circle circle = new Circle(radius);
                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                if(Validator.promptUser("Continue? (y/n) ", (response => response.ToLower()[0] == 'y'|| response.ToLower()[0] == 'n')).ToLower()[0] == 'n')
                {
                    break;
                }
            }
            Console.WriteLine($"Goodbye. You create {counter} Circle object(s).");
            Console.ReadKey();
        }

        
    }
}
