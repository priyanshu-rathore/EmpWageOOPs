using System;

namespace EmpWageOOPs{
    class Program{
        public static void Main(){
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart",20,2,10);
            empWageBuilder.addCompanyEmpWage("Reliance",10,4,20);
            empWageBuilder.computeEmpWage();

        }
    }
}