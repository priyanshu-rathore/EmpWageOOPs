using System;

namespace EmpWageOOPs
{
    internal class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 80;
        public static void EmpWage()
        {

            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalHrs = 0;

            //UC-1 Check employee present or not
            Random random = new Random();

            while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
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
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total wage for {0} days:{1} and Hrs:{2}", (day - 1), totalWage, (totalHrs - empHrs));
        }
    }
}