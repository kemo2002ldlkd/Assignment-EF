using System;
using Services;

class Program
{
    static void Main()
    {
        var departmentService = new DepartmentService();
        var employeeService = new EmployeeService();

        departmentService.AddDepartment("Sales");
        departmentService.AddDepartment("Media");
        departmentService.AddDepartment("Marketing");

        employeeService.AddEmployee("Ahmed", 29, 8000, 1);
        employeeService.AddEmployee("Nadia", 27, 5000, 2);
        employeeService.AddEmployee("Soha", 20, 3000, 3);
        employeeService.AddEmployee("Mazen", 25, 8000, 1);
        employeeService.AddEmployee("Sameh", 30, 9000, 2
