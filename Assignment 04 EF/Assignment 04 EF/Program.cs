#region Part 01 Join - Group join
var Result = dbContext.Employees.GroupJoin where(X => X.Departments.Count()
    Result = from  E in dbContext.Employess join D in dbContext.Departments
               on E.DepartmentDeptId equals D.DeptId into Depts

    select new
           {
               Employee = E,
               Departments = Depts
           }
      into X
    where X.Departments.Count() > 0
    select X;

foreach (var item in Result)
{
    Console.WriteLine($"Employeecode: {item.EmployeeCode}):: EmployeeName:{item.EmployeeName}";
    foreach (var department in item.Departments)
}
#endregion

#region Part 02 Left Outer join
var Result = dbContext.Employees.GroupJoin(dbContext.Departments,
    E => E.DepartmentDeptId,
    d => d.DeptId,
    (Employee, Departments) => new
    {
        Employee,
        Departments = Departments.DefaultIfEmpty()
    }).SelectMany(X => X.Departments, (X, Department) => new { X.Employee,Department });
foreach (var item in Result)
{
    Console.WriteLine ($"Employe: {item.Employee.Name}--Department : {item.Department?.Name??"no department"}");
    #endregion

#region Part 03 Cross Join
    

    var Result = from E in dbContext.Employees
                 from D in dbContext.Departments
                 select new
                 {
                     Employee = E,
                     Department = D
                 };

    Result = dbContext.Employees.SelectMany(E => dbContext.Departments.Select(D => new
    {
        Employee = E,
        Department = D
    }));

    foreach (var item in Result)
    {
        Console.WriteLine ($"Employee:{item.Employee.Name}::Department : {item.Depatmant.Name}");
    }


#endregion