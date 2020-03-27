using System;
namespace WarehouseApi.Models
{
    public class Warehouse
    {
        public string Name { get; set; }

        public Warehouse(string name)
        {
            this.Name = name;
        }
    }
}
