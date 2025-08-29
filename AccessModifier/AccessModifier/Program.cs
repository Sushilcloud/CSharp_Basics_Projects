namespace Assembly1
{   
    
    // Class Computer ..Field is public Access Modifier 
    class Computer
    {
        public string cName = "Lenove";
        private string cMemory = "4Gb";
    }
    public class Assembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public";

        public void TestAccess()
        {

            // Accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
            Console.WriteLine(internalVariable);
        }


    }

    public class Assembly1DerivedClass: Assembly1BaseClass
        {

        public void TestAccessInDerivedClass()
        {

            // Not Accessible
            //Console.WriteLine(privateVariable);
            
            // Accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
            Console.WriteLine(internalVariable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assembly1BaseClass objBase=new Assembly1BaseClass();
            objBase.TestAccess();
            Console.ReadKey();
            Computer computer=new Computer();

            //public Access Modifier
            Console.WriteLine("\n Access Modifier Public:- ");
            Console.WriteLine(computer.cName);

            // private Access Modifier not accessible because of protection level
            //Console.WriteLine(computer.cMemory);
        }
    }
}