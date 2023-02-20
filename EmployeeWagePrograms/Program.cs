// See https://aka.ms/new-console-template for more information
using EmployeeWagePrograms;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            // CheckEmployee obj= new CheckEmployee(); 
            //obj.checkEmployee();
            //Console.WriteLine("Welcome to the Employee Wage Computation");
            //CalculateDailyWage obj = new CalculateDailyWage();
            //obj.CalculateDailyWage
            CalculateMonthlyWage cm = new CalculateMonthlyWage();
            cm.montlyWage();


        }
    }
}
     