using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicproject
{
    public class UC5_WagePerMonth
    {
        public const float EmpWagePerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHrs_PerDay = 4;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 3;
        public const int Num_WorkingDays_PerMonth = 20;
        public float EmpMonthWage = 0;
        float EmpDailyWage = 0;

        public int IsEmployeePresent()
        {
            return new Random().Next() % 3;
        }
        public void CalculateWage()
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            while (DayNumber <= Num_WorkingDays_PerMonth)
            {
                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpWorkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkingHrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkingHrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * EmpWagePerHour;

                EmpMonthWage += EmpDailyWage;
                DayNumber++;
            }
            Console.WriteLine("Employee monthly wage :" + EmpWagePerHour);
        }

    }
}
