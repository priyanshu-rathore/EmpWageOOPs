using System;

namespace EmpWageOOPs{
    internal class EmployeeWage{
     public static void EmpWage(){
        const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0,empWage=0;

            //UC-1 Check employee present or not
            Random random = new Random();
            int employeeInput = random.Next(0, 3);
            //UC-4- Switch case
            switch (employeeInput)
            {
                case FULL_TIME:
                    Console.WriteLine("FullTime Employee is present");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("PartTime Employee is present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
            //UC-2 calculate EmployeeWage
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage is:"+empWage);           
     }
    }
}