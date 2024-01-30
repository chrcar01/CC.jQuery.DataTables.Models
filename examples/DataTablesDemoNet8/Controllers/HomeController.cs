using DataTablesDemoNet8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CC.jQuery.DataTables.Models;
using DataTablesDemoNet8.Repositories;

namespace DataTablesDemoNet8.Controllers;

public class HomeController(IEmployeeRepository employeeRepo) : Controller
{
    private readonly IEmployeeRepository _employeeRepo = employeeRepo;

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("api/employees")]
    public ActionResult GetPage(DataTableRequest request)
    {
        var orderByField = request.Columns[request.Order[0].Column].Name;
        var orderByDirection = request.Order[0].Dir;
        var (data, recordsFiltered, recordsTotal) = _employeeRepo.GetPage(request.Start, request.Length, orderByField, orderByDirection);
        var response = new DataTableResponse<Employee>
        {
            Draw = request.Draw,
            RecordsTotal = recordsTotal,
            RecordsFiltered = recordsFiltered,
            Data = data.ToArray()
        };

        return new JsonResult(response);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}