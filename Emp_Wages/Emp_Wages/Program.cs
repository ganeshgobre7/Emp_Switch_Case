using System;

namespace Emp_Wages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome To Employee Wage Computation**");
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            switch (empCheck)
            {
                case 1:
                    Console.WriteLine("Employee is Present");
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
