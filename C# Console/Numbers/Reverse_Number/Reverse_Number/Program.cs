using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int rev = 0, temp = 0, dig = 0;

            Console.WriteLine("Enter Number :");
            int No = Convert.ToInt32(Console.ReadLine());

            temp = No;

            while(No > 0)
            {
                dig = No % 10;
                rev = rev*10+dig;
                No /= 10;
            }

            Console.WriteLine("Original Number :" + temp);
            Console.WriteLine("Reverse Number :" + rev);

            Console.ReadKey();
        }
    }
}
