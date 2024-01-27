using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMachine
    {
        public PaymentMachine(string id, string name, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive, Company company)
        {
            Id = id;
            Name = name;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            Company = company;
            PaymentsMethods = new List<PaymentMethod>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }
        public Company Company { get; set; }
        public IEnumerable<PaymentMethod> PaymentsMethods { get; set; }
    }
}
