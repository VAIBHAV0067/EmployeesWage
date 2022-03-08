using System;
namespace EmployeesWageCaculation
{
    class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {

                Random random = new Random();
                int empCheck = random.Next(0,2);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * Emp_Rate_Per_Hour;

                Console.WriteLine("Emp Wage :" + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
