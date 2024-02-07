using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMachineForWorker
    {
        public PaymentMachineForWorker(string id, DateTime createdDate, DateTime finishedDate, DateTime updateDate, bool isActive, Worker worker, PaymentMachine paymentMachine)
        {
            Id = id;
            CreatedDate = createdDate;
            FinishedDate = finishedDate;
            UpdateDate = updateDate;
            IsActive = isActive;
            Worker = worker;
            PaymentMachine = paymentMachine;
        }

        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive {  get; set; }
        public Worker Worker { get; set; }
        public PaymentMachine PaymentMachine { get; set; }
    }
}
