using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Control_System
{
    public class Employee : Person
    {
        public int EmpId { get; set; }
        public double Salary;
        public string Department { get; set; }

       public Employee(int empId, double salary, string department)
        {
            EmpId = empId;
            Salary = salary;
            Department = department;
        }

        public double salarytax()
        {
            
            if (Salary > 20000)
            {
                Salary = Salary - (Salary * 0.10);
   
            }
            else if (Salary > 50000)
            {

                Salary = Salary - (Salary * 0.15);

            }
            if (Salary > 100000)
            {
                Salary = Salary - (Salary * 0.20);

            }
            return Salary;
           
        }
        public string tostring()
        {
            Console.WriteLine("Emp id  Name   Salary   Department    Age");
            string output = $"{EmpId}\t {Name}\t {Salary}\t {Department}\t {Age} ";
            return output;

        }
    }
}
