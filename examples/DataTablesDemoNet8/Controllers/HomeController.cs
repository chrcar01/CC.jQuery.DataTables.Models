using CC.jQuery.DataTables.Models;
using DataTablesDemoNet8.Models;
using DataTablesDemoNet8.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataTablesDemoNet8.Controllers;

public class HomeController(IEmployeeRepository employeeRepo) : Controller
{
    private readonly IEmployeeRepository _employeeRepo = employeeRepo;

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("api/employees")]
    public ActionResult GetPage(DataTableRequest request) => Json(_employeeRepo.GetPage(request));
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}