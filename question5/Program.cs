using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eval5
{
    internal class Program
    {
        public delegate void func(int a);

        public static void table(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a * i);
            }
        }

        public static void factorial(int a)
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;

            }
            Console.WriteLine("factorial = " + f);
        }
        static void Main(string[] args)
        {
            func f1 = new func(Program.factorial);
            Console.WriteLine("enter the num for factorial: ");
            int a = Convert.ToInt32(Console.ReadLine());
            f1(a);
            Console.WriteLine("enter the num for table: ");
            int d = Convert.ToInt32(Console.ReadLine());
            f1 = table;
            f1(d);

            Console.ReadLine();

        }
    }
}

