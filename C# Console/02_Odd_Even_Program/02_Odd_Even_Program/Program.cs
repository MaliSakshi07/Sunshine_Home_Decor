using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Even_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int No = 3;

            if(No % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.ReadKey();
        }
 
    }
}
