using System;

namespace GetAndSet
{

    class Person
    {
       private string name; //field

        public string Name  //property
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Sushil";
            
            Console.WriteLine(person.Name);
        }
    }
}