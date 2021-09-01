using System;

namespace Emp_Wages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome To Employee Wage Computation**");
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int Emp_Full_Time = 8;
            int Emp_Part_Time = 4;  
            int Per_Hour_Sal = 20;
            int One_Day_Sal = 0;
            int Num_Work_Day = 20;
            int Total_Sal = 0;

            switch (empCheck)
            {
                case 1:
                    Console.WriteLine("Employee is FullTime");
                    One_Day_Sal = Emp_Full_Time * Per_Hour_Sal;
                    Console.WriteLine("Employee Total Salary is:" + One_Day_Sal);
                    Total_Sal = One_Day_Sal * Num_Work_Day;
                    Console.WriteLine("Total Salary of Months:" + Total_Sal);
                    break;

                case 2:
                    Console.WriteLine("Employee is PartTime");
                    One_Day_Sal = Emp_Part_Time * Per_Hour_Sal;
                    Console.WriteLine("Employee Total Salary is:" + One_Day_Sal);
                        Total_Sal = One_Day_Sal * Num_Work_Day;
                        Console.WriteLine("Total Salary of Months:" + Total_Sal);

                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
