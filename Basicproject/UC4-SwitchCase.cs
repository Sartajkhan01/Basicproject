using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicproject
{
    public class UC4_SwitchCase
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        int EmpDailyWage = 0;

        public int EmpWage = 20;


        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpWage()
        {
            int EmpWorkingHrs = 0;
            int Is_Present = IsEmployeePresent();

                switch (Is_Present)
            {
                case IS_ABSENT:
                    EmpWorkingHrs = 0;
                    break;
                case IS_PART_TIME:
                    EmpWorkingHrs = 4;
                    break;
                case IS_FULL_TIME:
                    EmpWorkingHrs = 8;
                    break;

            }
            EmpDailyWage = EmpWorkingHrs * EmpWage;
                                                         
        }
    }
}
