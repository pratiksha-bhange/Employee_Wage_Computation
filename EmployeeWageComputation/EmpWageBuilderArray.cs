<<<<<<< HEAD
﻿using EmployeeWageComputation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage
{
    class EmpWageBuilderArray : IComputeEmpWage

    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        List<CompanyEmpWage> companyEmpWageList;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new List<CompanyEmpWage>();
>>>>>>> UC12-EmpWageByArrayList
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
<<<<<<< HEAD
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
=======
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.Add(companyEmpWage);
>>>>>>> UC12-EmpWageByArrayList
        }

        public void computeEmpWage()
        {
<<<<<<< HEAD
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
=======
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
>>>>>>> UC12-EmpWageByArrayList
            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmployeeHour = 0;
            while (totalEmployeeHour <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmployeeHour += empHrs;
                Console.WriteLine("Day=" + totalWorkingDays + " Emplyee hours=" + empHrs);
            }
            return totalEmployeeHour * companyEmpWage.empRatePerHour;
        }
    }
<<<<<<< HEAD
}
=======
}

    
>>>>>>> UC12-EmpWageByArrayList
