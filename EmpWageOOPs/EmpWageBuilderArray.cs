using System;
using System.Collections;

namespace EmpWageOOPs
{
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private ArrayList companies;

        // private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            companies = new ArrayList();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfworkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfworkingDays, maxHoursPerMonth);
            this.companies.Add(companyEmpWage);
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage i in this.companies)
            {
                int totalWage = computeEmpWage(i);
                i.setTotalEmpWage(totalWage);
                System.Console.WriteLine(i.toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0, dailyWage = 0;
            Random random = new Random();


            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        dailyWage = companyEmpWage.empRatePerHour * empHrs;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        dailyWage = companyEmpWage.empRatePerHour * empHrs;

                        break;
                    default:
                        empHrs = 0;
                        dailyWage = companyEmpWage.empRatePerHour * empHrs;

                        break;
                }

                totalEmpHrs += empHrs;
                System.Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs + " Daily wage : " + dailyWage);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}