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
      
    }          






        
    
