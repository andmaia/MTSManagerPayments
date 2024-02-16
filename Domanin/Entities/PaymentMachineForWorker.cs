using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMachineForWorker
    {
        public PaymentMachineForWorker(string id,string workerId,string paymentMachineId, DateTime createdDate, DateTime finishedDate, DateTime updateDate, bool isActive)
        {
            Id = id;
            CreatedDate = createdDate;
            FinishedDate = finishedDate;
            UpdateDate = updateDate;
            IsActive = isActive;
            WorkerId = workerId;
            PaymentMachineId = paymentMachineId;
        }

        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive {  get; set; }

        public string WorkerId {  get; set; }
        public Worker? Worker { get; set; }
        public string PaymentMachineId { get; set; }
        public PaymentMachine? PaymentMachine { get; set; }
    }
}
