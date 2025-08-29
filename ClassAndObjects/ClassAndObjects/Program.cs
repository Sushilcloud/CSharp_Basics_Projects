namespace ClassAndObject
{

    //Class
    class Student
    {
        //Fields under class
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //Method
        public void ShowDetails()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Id :{0},Name:{1},Age:{2},Address:{3}", Id, Name, Age, Address);
        }

        class Program
        {
            static void Main(string[] args)
            {   
                //Object
                Student student = new Student();
                student.Id = 1;
                student.Name = "Sushil";
                student.Age = 12;
                student.Address = "Dehradun";
                student.ShowDetails();
                Console.ReadKey();

            }
        }
    }
}