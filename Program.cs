
using BestBuyBestPractices;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

//var departmentRepo = new DapperDepartmentRepository(conn);

//departmentRepo.InsertDepartments("Patrick's New Department");

//var departments = departmentRepo.GetAllDepartments();

//foreach (var department in departments)
//{
//    Console.WriteLine(department.DepartmentID);
//    Console.WriteLine(department.Name);
//}

var productRepository = new DapperProductRepository(conn);
var products = productRepository.GetAllProducts();
foreach (var product in products)
{
    Console.WriteLine($"Product name: {product.Name}");
    Console.WriteLine($"Product ID: {product.ProductID}");
    Console.WriteLine($"Product price: {product.Price}");
    Console.WriteLine($"Product on sale: {product.OnSale}");
    Console.WriteLine($"Product stock level: {product.StockLevel}");
    Console.WriteLine();
    Console.WriteLine();
}