using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesWageCaculation
{
    public class Class1
    {
        public static void CheckEmployesPresent()
        {
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;
   

            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck ==IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {   
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;


            Console.WriteLine("Emp Wage :" + empWage);
        }   
    }
}
