using System;

namespace Conditional
{
    class Ifstatement  //Class 
    {
        public int num = 8; //Field
        public void ifelseMethod()  //Method
        {
            if(num<=5)
            {
                Console.WriteLine("{0} is less than or equal to 5");
            }
            else
            {
                Console.WriteLine("{0} is greater than 5");
            }

            
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Ifstatement ifstatement = new Ifstatement();  // Object   
            ifstatement.ifelseMethod();  // Call  class
            
           
        }
    }
}
