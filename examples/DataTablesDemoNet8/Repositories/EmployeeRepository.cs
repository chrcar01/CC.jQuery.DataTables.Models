using DataTablesDemoNet8.Models;
using System.Linq.Dynamic.Core;
using CC.jQuery.DataTables.Models;

namespace DataTablesDemoNet8.Repositories;

public class EmployeeRepository(IEnumerable<Employee> employees) : IEmployeeRepository
{
    private readonly List<Employee> _employees = [..employees];
    public DataTableResponse<Employee> GetPage(DataTableRequest request)
    {
        var orderByField = request.Columns[request.Order[0].Column].Name;
        var orderByDirection = request.Order[0].Dir;
        return new DataTableResponse<Employee>
        {
            Draw = request.Draw,
            RecordsTotal = _employees.Count,
            RecordsFiltered = _employees.Count,
            Data = _employees.AsQueryable().OrderBy($"{orderByField} {orderByDirection}").Skip(request.Start).Take(request.Length).ToArray()
        };
    }
}

