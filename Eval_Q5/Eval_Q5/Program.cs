namespace Eval_Q5
{
    public delegate void function(double a);
    internal class Program
    {
        
        public void Table(double num)
        {
            double ans = 0;
            for (int i = 1; i <= 10; i++)
            {
                ans = num * i;
                Console.WriteLine(ans);
            }

        }

        public void factorial(double num2)
        {
            double i, fact = 1;
            for (i = 1; i <= num2; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + num2 + " is: " + fact);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            function obj = new function(program.factorial);
            Console.WriteLine("Please enter the factor number");
            int num = Convert.ToInt32(Console.ReadLine());
            obj.Invoke(num);


            Console.WriteLine("Please enter the number for table");
            double num1 = Convert.ToInt32(Console.ReadLine());
            obj = program.Table;
            obj.Invoke(num1);

           

            
        }
    }
}