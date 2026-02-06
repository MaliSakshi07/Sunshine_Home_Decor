using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int dig = 0, temp = 0, pnum = 0;

            Console.WriteLine("Enter Number :");
            int No = Convert.ToInt32(Console.ReadLine());

            temp = No;

            while(No != 0)
            {
                dig = No % 10;
                pnum = (pnum * 10) + dig;
                No /= 10;
            }
            if(temp == pnum)
            {
                Console.WriteLine("Pallindrome Number");
            }
            else
            {
                Console.WriteLine("Not Pallindrome Number");
            }
            Console.ReadKey();
        }
    }
}
