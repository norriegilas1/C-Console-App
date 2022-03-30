namespace FinalProject
{
    public class EmployeeController : IFunctions
    {

        private List<Employee> _employee { get; set; } = new List<Employee>();
        private void displaySearchOutput(Employee employee)
        {
            Console.WriteLine($"********************");
            Console.WriteLine($"Name :\t\t{employee.Name}");
            Console.WriteLine($"Salary :\t{employee.Salary}");
        }

        public void addEmployee(Employee employee)
        {
            _employee.Add(employee);
            Console.WriteLine("Employee Record Successfully Added!");

        }

        public void viewEmployee(string employeeName)
        {
            var employee = _employee.FirstOrDefault(c => c.Name == employeeName);
            if (employee == null)
            {
                throw new Exception("No Name Entered");
            }
            else
            {
                Console.WriteLine($"Employee Record Found :");
                displaySearchOutput(employee);
            }
        }

        public void viewAllEmployee()
        {
            foreach (var employee in _employee)
            {
                displaySearchOutput(employee);
            }
        }

        public void updateEmployee(string employeeName, double newEmployeeDetail)
        {
            var employee = _employee.FirstOrDefault(c => c.Name == employeeName);
            employee.Salary = newEmployeeDetail;

        }

        public void deleteEmployee(string employeeName)
        {
            var employee = _employee.FirstOrDefault(c => c.Name == employeeName);
            _employee.Remove(employee);
            Console.WriteLine("Employee Record Successfully Deleted!");

        }

    }
}