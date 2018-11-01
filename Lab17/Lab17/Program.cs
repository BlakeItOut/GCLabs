using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class Program
    {
        static int[] primes = GetUpTo100000ThPrime();
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!\n\nThis application will find you any prime, in order, from the first prime number (2) on.");
            while (true)
            {
                int nth = int.Parse(Validator.promptUser("Which sequence number prime are you looking for? (between 1 and 100000, inclusive) ", (num => int.TryParse(num, out nth) && nth > 0 && nth <= 100000)));
                Console.WriteLine($"\nThe sequence number {nth} prime is {LocatePrime(nth)}.\n");
                if (!Validator.promptYN("Do you want to find another prime number? (y/n) "))
                {
                    break;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Goodbye");
            Console.ReadKey();
            
        }

        public static int LocatePrime(int nth)
        {
            return primes[nth-1];
        }

        public static bool CheckPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false;     

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static int[] GetUpTo100000ThPrime()
        {
            int [] primes = new int [100000];
            int counter = 0;
            for(int i = 0; i <= 1299709; i++)
            {
                if (CheckPrime(i))
                {
                    primes[counter++] = i;
                }
            }
            return primes;
        }
    }
}
