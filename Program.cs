using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            char symbol;
            int count = 0;

            do
            {
                Console.Write("Enter symbol: ");
                symbol = char.Parse(Console.ReadLine());

                if (symbol == ' ')
                {
                    count++;
                }


            } while (symbol != '.');

            Console.WriteLine("Count of gaps - "+count);
            Console.WriteLine();



            //#2
            int sumFirstNumbers, sumLastNumbers;

            Console.Write("Enter six-digit number : ");

            int ticket = int.Parse(Console.ReadLine());
            if (ticket > 99999 && ticket < 9999999)            {
               

                sumFirstNumbers = ticket % 10 + (ticket % 100) / 10 + (ticket % 1000) / 100;
                sumLastNumbers = (ticket % 10000) / 1000 + (ticket % 100000) / 10000 + (ticket % 1000000) / 100000;

                if (sumFirstNumbers == sumLastNumbers)
                {
                    Console.WriteLine("Your ticket is lucky");
                }
                else
                {
                    Console.WriteLine("Your ticket is unlucky");

                }
            }
            else
            { 
                Console.WriteLine("Error! You need to enter six-digit number : ");
            }
            Console.WriteLine();



            //#3
            int a, b;
            Console.Write("Enter number A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter number B > A: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 1; j <= i; j++)

                    {
                        Console.Write(i+" ");
                    }
                    Console.WriteLine();
                }
            }
            else 
            { 
            Console.WriteLine("Invalid number B");
            }


            //#4
            Console.WriteLine("Enter number N > 0 : ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                string inversNumber = Convert.ToString(n);
                inversNumber = new string(inversNumber.Reverse().ToArray());
                Console.WriteLine(inversNumber);
            }
            else 
            {
                Console.WriteLine("Your number must be > 0! ");
            }

           
        }
    }
}
