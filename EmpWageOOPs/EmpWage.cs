using System;

namespace EmpWageOOPs{
    internal class EmployeeWage{
     public static void EmpWage(){
        const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            int empHrs = 0,empWage=0,totalWage=0,day=1;

            //UC-1 Check employee present or not
            Random random = new Random();

            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int employeeInput = random.Next(0, 3);
                //UC-4- Switch case
                switch (employeeInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                //UC-2 calculate EmployeeWage
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage; //totalWage=totalWage+empWage
            }
            Console.WriteLine("Total wage for {0} days:{1}",(day-1), totalWage);           
     }
    }
}