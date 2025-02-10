using System.Collections.Generic;

namespace Pay_Control_System
{
    public class Program
    {
       
        static void Main(string[] args)

        {
            List<Employee> Employee_list = new List<Employee>();     // using list

            Employee o1=new Employee(001,30000,"hr");
            Employee_list.Add(o1);
            

            int choice=0;
            while (choice==3)
            { 

                Console.Write("Press '1' -To input Data '2'- To show data '3'- To Exit:");
                choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        userinput(Employee_list);
                        
                        break;
                    case 2:
                        showdetail(Employee_list);
                        break;
                    case 3:
                        Console.WriteLine("Good Bye");
                        break;
                    
                    default:
                        Console.WriteLine("Wrong input");
                        break ;
                        
                }

            }

        }

        //method list................................................................................
         static void userinput(List<Employee> Employee_list)   //using list
        
        {
            string name = stringstring("Enter employee Name:");
            int id = intstring("Enter Employee Id:");
            double salary = doublestring("Enter Salary:");
            string department = stringstring("Enter Department:");

            Console.Write("Input your Birthday:");
            DateTime birthday=Convert.ToDateTime(Console.ReadLine());
            int age = Agecal(birthday.Year,DateTime.Now.Year);

            Employee newemployee= new Employee(id,salary,department);
            Employee_list.Add(newemployee);         //data add to list
        
            Console.WriteLine("Add succesful");
            
        }

        static void showdetail(List<Employee> Employee_list) // using list          
        {
            foreach(Employee i in Employee_list)
            {
                Console.WriteLine(i.tostring());
            }
        }

        static int intstring(string str)
        {
            Console.Write(str);
            string output=Console.ReadLine();
            return int.Parse(output);  
        }
        static string stringstring(string str)
        {
            Console.Write(str);
            string output=Console.ReadLine();
            return output;
        }

        static double doublestring(string str)
        {
            Console.Write(str);
            string output = Console.ReadLine();
            return double.Parse(output);   

        }

        static int Agecal(int currentYear, int BirthYear)
        {
            int age=currentYear-BirthYear;
            return age;
        }

    }
}
