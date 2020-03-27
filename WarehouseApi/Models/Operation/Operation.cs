using System;
namespace WarehouseApi.Models.Operation
{
    public class Operation
    {

        public int Id { get; set; }

        public int OperationTypeId { get; set; }

        public string SenderObjectName { get; set; }

        public string ReceiverObjectName { get; set; }

        public Operation(int id, int operationTypeId, string senderObjectName, string receiverObjectName)
        {
            Id = id;
            OperationTypeId = operationTypeId;
            SenderObjectName = senderObjectName;
            ReceiverObjectName = receiverObjectName;
        }

    }
}
