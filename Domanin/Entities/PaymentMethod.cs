﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMethod
    {
        public PaymentMethod(string id,string paymentMachineId, string name, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive, float tax)
        {
            Id = id;
            Name = name;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            Tax = tax;
            PaymentMachineId = paymentMachineId;
            PaymentUnities = new List<PaymentUnity>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }
        public float Tax { get;set; }

        public string PaymentMachineId { get; set; }
        public PaymentMachine? PaymentMachine { get; set; }
        public IEnumerable<PaymentUnity> PaymentUnities { get; set; }
    }
}
