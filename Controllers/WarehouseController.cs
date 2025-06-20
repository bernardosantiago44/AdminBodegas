using AdminBodegas.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Text.Json;

namespace AdminBodegas.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            List<Coordinacion> coordinacions = ReadCoordinations();

            return View(coordinacions);
        }
        private List<Coordinacion> ReadCoordinations()
        {
            var json = ReadJson();
            List<Coordinacion>? coordinaciones = JsonSerializer.Deserialize<List<Coordinacion>>(json);
            if (coordinaciones == null)
            {
                Log.Fatal("Could not deserialize JSON at WarehouseAPIController.ReadCoordinations()");
                throw new Exception("Could not deserialize JSON");
            }
            return coordinaciones;
        }

        private string ReadJson()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/Warehouse.json");

            if (!System.IO.File.Exists(filePath))
            {
                Log.Fatal("No such file or directory: ", filePath);
                throw new Exception("No such file: " + filePath);
            }

            var json = System.IO.File.ReadAllText(filePath);
            return json;
        }
    }
}
