using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicproject
{
    internal class UC3_PartTime
    {
        public int EmpPresent = 1;
        public int FullTime = 1;
        public int Wage_Per_Hour = 20;
        public int Full_Day_hour = 8;
        public int PartTime_Day_hour = 4;
        public int DailyWage = 0;
        public void CheckEmpPresentAbsent()
        {
            Random EmpCheck = new Random();
            int Value = EmpCheck.Next(0, 2);

            if (Value == EmpPresent)
            {
                Random TimeCheck = new Random(0);
                int WorkingHours = TimeCheck.Next(0, 2);
                if (WorkingHours == FullTime)
                {
                    DailyWage = Wage_Per_Hour * Full_Day_hour;
                    Console.WriteLine("Employee is Present" + DailyWage);
            }
            else
            {
                DailyWage = Wage_Per_Hour * PartTime_Day_hour;
                Console.WriteLine("Employee is present for PartTime" + DailyWage);
            }
        }
        else
        {
        Console.WriteLine("Employee is absent");
            }
        }   
    }
}
