namespace Eval_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("Enter the fuel");
            int fuel = int.Parse(Console.ReadLine());
                if (car.Refuel(fuel))
                {
                    car.Drive();
                }
        }

            public interface Vehicle
            {
                void Drive();
                bool Refuel(int amount);
            }

            public class Car : Vehicle
            {
            public int Fuel;

                public Car(int fuel)
                {
                    Fuel = fuel;
                }

                public void Drive()
                {
                    if (Fuel > 0)
                    {
                        Console.WriteLine("Driving");
                    }
                    else
                    {
                        Console.WriteLine("No fuel");
                    }
                }

                public bool Refuel(int amount)
                {
                    Fuel += amount;
                    return true;
                }
            }
        }
    }
    
