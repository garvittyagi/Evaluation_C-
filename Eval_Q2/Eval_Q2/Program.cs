using System.Collections;

namespace Eval_Q2
{
    class Phonebook
    {
        public string name;
        public string Prof;
        public int age;
        public double num;

        public void readers(string name, string Prof, int age, double num)
        {
            this.name = name;
            this.Prof = Prof;
            this.age = age;
            this.num = num;

            if (age < 18)
            {
                Console.WriteLine(" ");
                Console.WriteLine("\nStudents:\n");
                Console.WriteLine(" Name is : " + name);
                Console.WriteLine(" age: " + age);
                Console.WriteLine(" number: " + num);
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("\nCitizens:\n");
                Console.WriteLine(" Name is: " + name);
                Console.WriteLine(" age: " + age);
                Console.WriteLine(" number: " + num);
            }

        }
    }
    class Profession : Phonebook
    {
        public Profession(string name, string Prof, int age, double num)
        {
            this.name = name;
            this.Prof = Prof;
            this.age = age;
            this.num = num;
            Console.WriteLine("");
            Console.WriteLine("\nServices and Professionals:\n");
            Console.WriteLine(" Name is : " + name);
            Console.WriteLine(" Proffesion: " + Prof);
            Console.WriteLine(" age: " + age);
            Console.WriteLine(" number: " + num);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Profession obj = new Profession("Kirti", "doctor", 20, 1234567890);
            obj.readers("riya", "", 25, 1234567890);
            obj.readers("Rekha", "", 45, 1234567890);
            obj.readers("nisha", "", 17, 1234567890);
            obj.readers("Hema", "", 17, 1234567890);
            obj.readers("Gaurav", "", 12, 1234567890);
            obj.readers("Bhavna", "", 25, 1234567890);

        }
    }
}
