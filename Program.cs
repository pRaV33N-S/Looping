using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string choice;
            do
            {
                Console.WriteLine("Enter the tables number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tables of {num} as follows");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num}*{i}=\t {(num * i)}");
                }
                Console.WriteLine("Do you wanna continue \n if Yes press Y \n else press any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
        }
    }
}
