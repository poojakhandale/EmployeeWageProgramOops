﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePrograms
{
   public class EmployeeWageMultiple
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public int empHrs = 8, totalEmpHrs = 0, totalWorkingDays = 0;
        public string company;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int empRatePerHour;
        public int totalEmpWage;
        public int EmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
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
                        empHrs = 0; break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "EmpHrs: " + empHrs);
            }

            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company :" + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }
    
    }
}
