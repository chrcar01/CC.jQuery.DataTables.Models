using System.Text.Json;
using DataTablesDemoNet8.Models;
using DataTablesDemoNet8.Repositories;

namespace DataTablesDemoNet8;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        if (!File.Exists("Mockaroo.MockData.json")) throw new FileNotFoundException("Make sure the Mockaroo.MockData.json file is in the bin directory!");
        var mockData = File.ReadAllText("Mockaroo.MockData.json");
        if (string.IsNullOrEmpty(mockData)) throw new InvalidOperationException("This demo needs data and the Mockaroo.MockData.json file is empty!");
        var employees = JsonSerializer.Deserialize<List<Employee>>(mockData, new JsonSerializerOptions{ PropertyNameCaseInsensitive = true});
        if (employees is null) throw new InvalidOperationException("The Mockaroo.MockData.json file does not contain valid data!");
        builder.Services.AddSingleton<IEmployeeRepository>(new EmployeeRepository(employees));
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}