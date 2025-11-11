using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_details_in_non_and_withpar
{
    internal class Program
    {
        class Employee
        {
            int empid;
            string empname;
            double empsal;
            public string Accepting(int id,string name,double sal)
            {
                empid = id;
                empname = name;
                empsal = sal;
                return "Employee  details  accepted succesfully";
            }
            internal string Display(int empid,string empname,double empsal)
            {
                return $"empid:{empid}\nempname:{empname}\nempsal:{empsal}";
                
            }
        }
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            string result = obj.Accepting(101,"Ramya", 50000);
            Console.WriteLine(result);
            string info = obj.Display(101,"Ramya",50000);
            Console.WriteLine("details  informations");
            Console.WriteLine(info);
        }
    }
}
//add line
