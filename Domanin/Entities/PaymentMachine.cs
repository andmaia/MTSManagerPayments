﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMachine
    {
        public PaymentMachine(string id,string companyId, string name, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive)
        {
            Id = id;
            Name = name;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            CompanyId = companyId;
            PaymentsMethods = new List<PaymentMethod>();
            PaymentMachineForWorkers = new List<PaymentMachineForWorker>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }

        public string CompanyId { get; set; }
        public Company? Company { get; set; }
        public IEnumerable<PaymentMethod> PaymentsMethods { get; set; }
        public IEnumerable<PaymentMachineForWorker> PaymentMachineForWorkers { get; set; } 
    }
}
