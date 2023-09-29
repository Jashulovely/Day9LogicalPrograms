using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool interested = true;
            while (interested)
            {
                Console.WriteLine("Enter Choice :\n   1   -->   Fibonacci Series.\n   0   -->   QUIT.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.GetSeries();
                        Console.ReadLine();
                        break;
                    case 0:
                        interested = false;
                        Console.WriteLine("Thanks for your ineterest.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
