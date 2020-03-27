using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WarehouseApi.DBContext;
using WarehouseApi.Models;

namespace WarehouseApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                // создаем два объекта product
                Product product1 = new Product("морковка","0000000001",10,15);
                Product product2 = new Product("картошка", "0000000002", 15, 20);

                // добавляем их в бд
                db.Products.Add(product1);
                db.Products.Add(product2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var products = db.Products;
                Console.WriteLine("Список объектов:");
                foreach (Product p in products)
                {
                    Console.WriteLine("{0}-{1}: Объем:{2}, Вес:{3}", p.VendorСode, p.Name, p.Volume, p.Weight);
                }
            }
            Console.Read();
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
