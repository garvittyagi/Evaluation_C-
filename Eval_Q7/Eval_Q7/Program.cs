using System.Collections;

namespace Eval_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            int total = 5;

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Please enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your age");
                int age = int.Parse(Console.ReadLine());

                queue.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < total; i++)
            {
                Person p = (Person)queue.Dequeue();
                Console.WriteLine(p.ToString());
            }
        }

        public class Person
        {
            public string Name;
            public int Age;


            public override string ToString()
            {
                return Name + " : " + Age;
            }
        }
    }
}