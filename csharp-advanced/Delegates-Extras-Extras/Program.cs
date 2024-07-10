namespace CSharp
{
    public delegate bool IsPromotable(Employee empl);

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee emp in employeeList)
            {
                if(IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, isPromotable);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}