namespace Eval_Q9
{
    delegate bool isPromote(Employee emp);
    class Employee
    {
        public int ID;
        public string Name;
        public int salary;
        public float Experience;
        public static void PromoteEmp(List<Employee> EmployeeList, isPromote IsEligible)
        {
            foreach (var emp in EmployeeList)
            {
                if (IsEligible(emp))
                {
                    Console.WriteLine(emp.Name + " is Promoted");
                }
            }
        }
        public static bool promote(Employee emp)
        {
            if (emp.Experience >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 101, Name = "random", salary = 25000, Experience = 3 });
            empl.Add(new Employee() { ID = 102, Name = "Mohit", salary = 38000, Experience = 5 });
            empl.Add(new Employee() { ID = 103, Name = "Garvit", salary = 50000, Experience = 8 });
            empl.Add(new Employee() { ID = 104, Name = "Kartik", salary = 10000, Experience = 2 });
            empl.Add(new Employee() { ID = 105, Name = "Ajay", salary = 5000, Experience = 1 });



            isPromote pro = new isPromote(promote);
            Employee.PromoteEmp(empl, pro);
        }
    }

}