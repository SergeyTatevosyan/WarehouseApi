using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WarehouseApi.DBContext;
using WarehouseApi.Models;

namespace WarehouseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCar")]
        public ActionResult Get()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                Product product1 = new Product("Товар1", "0000000001", 5, 15);
                Product product2 = new Product("Товар2", "0000000002", 10, 25);

                db.Products.Add(product1);
                db.Products.Add(product2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");


                Console.WriteLine("Список объектов:");
                foreach (Product pr in db.Products)
                {
                    Console.WriteLine("{0}.{1},{2},{3}", pr.Name, pr.VendorСode, pr.Weight, pr.Volume);
                }
            }

            return Ok("");
        }


    }
}
