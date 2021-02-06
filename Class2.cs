using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattrans
{
    class Class2
    {
        static void Main(string[] args)
        {
            int num = 5;
             int var = 1;
            
            for (int i = 1; i <=num; i++)
            {
                for (int j = 1; j <= i;j++)
                {
                    Console.Write(var+"\t");
                    var++;
                }
                Console.WriteLine();
            }
        }
    }
}
