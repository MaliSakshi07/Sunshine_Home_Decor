using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String__Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = string.Copy(s1);

            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }

}
