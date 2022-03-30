namespace FinalProject
{
    interface IFunctions
    {
        void addEmployee(Employee employee);
        void viewEmployee(string employeeName);
        void viewAllEmployee();
        void updateEmployee(string employeeName, double newEmployeeDetail);
        void deleteEmployee(string employeeName);

    }
}