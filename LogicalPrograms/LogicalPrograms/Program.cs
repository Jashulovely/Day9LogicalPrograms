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
                Console.WriteLine("Enter Choice :\n   1   -->   Fibonacci Series.\n   2   -->   Perfect Number.\n" +
                    "   3   -->   Prime Number.\n   4   -->   Reverse Number.\n   5   -->   Stop Watch.\n" +
                    "   6   -->   Coupon Codes.\n   0   -->   QUIT.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.GetSeries();
                        Console.ReadLine();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.IsPerfectNumber();
                        Console.ReadLine();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.IsPrime();
                        Console.ReadLine();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse();
                        Console.ReadLine();
                        break;
                    case 5:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Stop();
                        Console.ReadLine();
                        break;
                    case 6:
                        CouponCode couponCode = new CouponCode();
                        couponCode.Coupon();
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
