using System.Collections.Generic;
using System.Linq;
using Models;
using Data;
using Microsoft.EntityFrameworkCore;
using Assignment_03_EF;

public class EmployeeService
{
    private readonly AppDbContext _context;

    public EmployeeService()
    {
        _context = new AppDbContext();
    }

    public void AddEmployee(string name, int age, decimal salary, int? departmentId)
    {
        var employee = new Employee { Name = name, Age = age, Salary = salary, DepartmentId = departmentId };
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public List<Employee> GetAllEmployees()
    {
        return _context.Employees.Include(e => e.Department).ToList();
    }

    public void UpdateEmployee(int id, string name, int age, decimal salary, int? departmentId)
    {
        var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            employee.Name = name;
            employee.Age = age;
            employee.Salary = salary;
            employee.DepartmentId = departmentId;
            _context.SaveChanges();
        }
    }

    public void DeleteEmployee(int id)
    {
        var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }
}
