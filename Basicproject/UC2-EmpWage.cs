using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicproject
{
    internal class UC2_EmpWage
    {

        public int EmpPresent = 1;
        public int Wage_Per_Hour = 20;
        public int Full_Day_hour = 8;
        public int PartTime_Day_Hour = 4;

        public void CheckEmpPresentAbsent()
        {
            Random EmpCheck = new Random();
            int Value = EmpCheck.Next(0, 2);

            if (Value == EmpPresent)
            {
                int DailyWage = Wage_Per_Hour * Full_Day_hour;
                Console.WriteLine("Employee is Present" + DailyWage);

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                



            }
        }

    }
}



        
        
