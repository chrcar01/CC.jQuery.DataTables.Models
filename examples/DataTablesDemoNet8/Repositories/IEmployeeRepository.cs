using CC.jQuery.DataTables.Models;
using DataTablesDemoNet8.Models;

namespace DataTablesDemoNet8.Repositories;

public interface IEmployeeRepository
{
    DataTableResponse<Employee> GetPage(DataTableRequest request);
}