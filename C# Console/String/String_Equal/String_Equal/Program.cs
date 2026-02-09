using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Sakshi";
            string str2 = "Mali";
            string str3 = "Sakshi";

            Console.WriteLine("String Equal :" + str1.Equals(str2));
            Console.WriteLine("\nString Equal :" + str1.Equals(str3));

            Console.ReadKey();
        }
    }
}
