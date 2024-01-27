using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Procedure
    {
        public Procedure(string id, string customerName, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive, Worker worker, Payment payment)
        {
            Id = id;
            CustomerName = customerName;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            Worker = worker;
            Payment = payment;
        }

        public string Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }
        public Worker Worker { get; set; }
        public Payment Payment { get; set; }   
    }
}
