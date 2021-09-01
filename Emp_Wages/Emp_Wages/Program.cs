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

            int Emp_Full_Time = 8;
            int Per_Hour_Sal = 20;
            int Total_Sal = 0;

            switch (empCheck)
            {
                case 1:
                    Console.WriteLine("Employee is FullTime");
                    Total_Sal = Emp_Full_Time * Per_Hour_Sal;
                    Console.WriteLine("Employee Total Salary is:" + Total_Sal);
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
