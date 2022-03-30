namespace FinalProject
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Welcome to Employee Payroll!!!");
            printMainMenu();
            char process = Console.ReadKey(true).KeyChar;

            EmployeeController newEmployeeController = new EmployeeController();

            while (true)
            {
                string employeeName;

                switch (process)
                {
                    case 'a':

                        Console.WriteLine("Enter Employee Name:");
                        string newEmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary:");
                        double newEmployeeSalary = Convert.ToDouble(Console.ReadLine());

                        Employee newEmployee = new Employee(newEmployeeName, newEmployeeSalary);
                        newEmployeeController.addEmployee(newEmployee);

                        break;

                    case 'b':

                        Console.WriteLine("Enter Employee Name:");
                        employeeName = Console.ReadLine();
                        newEmployeeController.viewEmployee(employeeName);
                        break;

                    case 'c':

                        newEmployeeController.viewAllEmployee();
                        break;

                    case 'd':

                        Console.WriteLine("Enter Employee Name :");
                        employeeName = Console.ReadLine();
                        Console.WriteLine("Enter Employee's New Salary :");
                        double newemployeeDetail = Convert.ToDouble(Console.ReadLine());
                        newEmployeeController.updateEmployee(employeeName,newemployeeDetail);
                        break;

                    case 'e':

                        Console.WriteLine("Enter Employee Name:");
                        employeeName = Console.ReadLine();
                        newEmployeeController.deleteEmployee(employeeName);
                        break;

                    case 'x':

                        Console.WriteLine("***********************************");
                        Console.WriteLine("Thank you for using the Payroll App. Good bye!");
                        return;

                    default:

                        Console.WriteLine("Invalid key entered");
                        break;

                }

                printMainMenu();
                process = Console.ReadKey(true).KeyChar;
            }
        }

        static void printMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Please Press a Key To Continue...");
            Console.WriteLine("***********************************");
            Console.WriteLine("A - Create New Employee Record");
            Console.WriteLine("B - Search For An Employee Record");
            Console.WriteLine("C - View All Records");
            Console.WriteLine("D - Update an Employee Information");
            Console.WriteLine("E - Delete an Employee Information");
            Console.WriteLine("X - Exit");
        }

    }
}