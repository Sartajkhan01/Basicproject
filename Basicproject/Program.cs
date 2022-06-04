namespace Basicproject
{
    class program
    {
        public int EmpPresent = 1;
        
 

        //checking functionality === Method

        public void CheckEmpPresentAbsent()
        {
            Random EmpCheck = new Random(); //Random =class Empcheck =object
           int Value = EmpCheck.Next(0, 2);  //Next=method

            if (Value == EmpPresent)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(string[]args)
        {
            UC6_WagePerHrsMonth prg = new UC6_WagePerHrsMonth();
            prg.CalucalteWage();
            






        }
    }
}