using System;
namespace WarehouseApi.Models.Operation
{
    public class OperationType
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public OperationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
