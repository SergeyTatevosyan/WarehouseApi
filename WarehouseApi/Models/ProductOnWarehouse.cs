using System;
namespace WarehouseApi.Models
{
    public class ProductOnWarehouse
    {
        public string WarehoseName { get; set; }

        public string ProductName { get; set; }

        public int CountProduct;

        public ProductOnWarehouse(string warehoseName, string productName, int countProduct)
        {
            WarehoseName = warehoseName;
            ProductName = productName;
            CountProduct = countProduct;
        }
    }
}
