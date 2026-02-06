using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int dig, temp, Anum=0;

            Console.WriteLine("Enter Number : ");
            int No = Convert.ToInt32(Console.ReadLine());

            temp = No;
            
            while(No > 0)
            {
                dig = No % 10;
                Anum = Anum+(dig * dig * dig);
                No = No/ 10;
            }
            if(temp == Anum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("\nNot Armstring Number");
            }
            Console.ReadKey();
        }
    }
}
