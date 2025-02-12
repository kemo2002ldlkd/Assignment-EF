using System.Collections.Generic;
using System.Linq;
using Models;
using Data;
using Assignment_03_EF;

public class DepartmentService
{
    private readonly AppDbContext _context;

    public DepartmentService()
    {
        _context = new AppDbContext();
    }

    public void AddDepartment(string name)
    {
        var department = new Department { Name = name };
        _context.Departments.Add(department);
        _context.SaveChanges();
    }

    public List<Department> GetAllDepartments()
    {
        return _context.Departments.ToList();
    }
}
