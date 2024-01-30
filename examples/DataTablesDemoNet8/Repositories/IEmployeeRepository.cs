using DataTablesDemoNet8.Models;

namespace DataTablesDemoNet8.Repositories;

public interface IEmployeeRepository
{
    (List<Employee> data, int recordsFiltered, int recordsTotal) GetPage(int start, int length, string orderByField, string orderByDirection);
}