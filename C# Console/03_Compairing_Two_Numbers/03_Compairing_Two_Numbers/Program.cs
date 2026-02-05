using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Compairing_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int No1 = 30, No2 = 32;

            if(No1 > No2)
            {
                Console.WriteLine("No1 is big than No2 ");
            }
            else if(No1 < No2)
            {
                Console.WriteLine("No1 is smaller than No2");
            }
            else
            {
                Console.WriteLine("Both Numbers are Equal");
            }
            Console.ReadKey();
        }
    }
}
