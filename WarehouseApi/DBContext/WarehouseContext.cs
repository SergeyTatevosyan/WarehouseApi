using System;
using System.Data.Entity;
using WarehouseApi.Models;
using WarehouseApi.Models.Operation;

namespace WarehouseApi.DBContext
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext():base("DbConnection")
        {
        }

        /// <summary>
        /// Склад
        /// </summary>
        public DbSet<Warehouse> Warehouses { get; set; }

        /// <summary>
        /// Товары
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Товары на складе - слотник
        /// </summary>
        public DbSet<ProductOnWarehouse> ProductsOnWarehouses { get; set; }

        /// <summary>
        /// Операции перемещения
        /// </summary>
        public DbSet<Operation> Operations { get; set; }

        /// <summary>
        /// Типы операций перемещения
        /// </summary>
        public DbSet<OperationType> OperationTypes { get; set; }

    }
}
