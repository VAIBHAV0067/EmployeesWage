using System;
namespace EmployeesWageCaculation
{
    class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hrs_In_Month = 100;
        
        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            
           
            while( totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
