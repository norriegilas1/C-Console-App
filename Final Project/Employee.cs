namespace FinalProject
{
    public class Employee
    {
        private string name;
        private double salary;

        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public Employee(string name, double salary)

        {
            Name = name;
            Salary = salary;
        }

    }
}