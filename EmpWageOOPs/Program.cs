using System;

namespace EmpWageOOPs{
    class Program{
        public static void Main(){
            EmployeeWage dmart = new EmployeeWage("Dmart",20,2,10);
            EmployeeWage Reliance = new EmployeeWage("Reliance",10,4,20);

            dmart.computeEmpWage();
            System.Console.WriteLine(dmart.toString());
            Reliance.computeEmpWage();
            System.Console.WriteLine(Reliance.toString());

        }
    }
}