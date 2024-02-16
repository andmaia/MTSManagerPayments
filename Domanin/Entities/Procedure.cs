using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Procedure
    {
        public Procedure(string id,string workerId,string paymentId, string customerName, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive)
        {
            Id = id;
            CustomerName = customerName;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            WorkerId = workerId;
            PaymentId = paymentId;

        }

        public string Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }

        public string WorkerId { get; set; }
        public string PaymentId { get; set; }
        public bool IsActive { get; set; }
        public Worker? Worker { get; set; }
        public Payment? Payment { get; set; }   
    }
}
