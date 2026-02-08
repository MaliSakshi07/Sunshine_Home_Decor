using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Employee
    {
        public string Name;
        public abstract void calculateSalary();
        public void Display()
        {
            Console.WriteLine("Employee Name :" + Name);
        }
    }

    class Developer : Employee
    {
        public int BasicSalary = 20000;

        public override void calculateSalary()
        {
            Console.WriteLine("Developer Salary :" + BasicSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Developer();

            emp.Name = "Sakshi Mali";
            emp.Display();
            emp.calculateSalary();
        }
    }
}
