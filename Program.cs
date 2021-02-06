using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattrans
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num = 5;
             Console.WriteLine("enter your number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <=num; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
