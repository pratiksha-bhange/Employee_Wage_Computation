using System;

namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program On Master Branch");

            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is prsent");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
