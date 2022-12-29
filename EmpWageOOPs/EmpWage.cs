using System;

namespace EmpWageOOPs{
    internal class EmployeeWage{
     public static void EmpWage(){
        const int IS_PRESENT = 1;
            //UC-1 Check employee present or not
            Random random = new Random();
            int employeeInput = random.Next(0, 2);

            if (IS_PRESENT == employeeInput)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            
     }
    }
}