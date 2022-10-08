namespace Eval_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird parrot = new Parrot();
            Console.WriteLine("Enter the bird name");
            parrot.SetName(Console.ReadLine());
            Console.WriteLine(parrot.GetName());
            parrot.fly();
            parrot.Eat();
        }

        public class Parrot : Bird
        {
            public override void Eat()
            {
                Console.WriteLine($"The {Name} is Eating");
            }
        }

        public abstract class Bird
        {
            public string Name;

            public void SetName(string name)
            {
                this.Name = name;
            }

            public string GetName()
            {
                return Name;
            }

            public void fly()
            {
                Console.WriteLine($"The {Name} is flying ");
            }
            public abstract void Eat();
        }
    }
}