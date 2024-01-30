using DataTablesDemoNet8.Models;
using System.Linq.Dynamic.Core;
namespace DataTablesDemoNet8.Repositories;

public class EmployeeRepository(IEnumerable<Employee> employees) : IEmployeeRepository
{
    private readonly List<Employee> _employees = [..employees];
    public (List<Employee> data, int recordsFiltered, int recordsTotal) GetPage(int start, int length, string orderByField, string orderByDirection)
    {
        var data = _employees.AsQueryable().OrderBy($"{orderByField} {orderByDirection}").Skip(start).Take(length).ToList();
        return (data, _employees.Count, _employees.Count);
    }
}

