using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Payment
    {
        public Payment(string id, DateTime createdDate, DateTime finishedDate, float percentageDefault, PaymentSummary paymentSummary, PaymentStatus paymentStatus)
        {
            Id = id;
            CreatedDate = createdDate;
            FinishedDate = finishedDate;
            PercentageDefault = percentageDefault;
            PaymentSummary = paymentSummary;
            PaymentStatus = paymentStatus;
            PaymentUnities = new List<PaymentUnity>();
        }

        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public float PercentageDefault { get; set; }
        public PaymentSummary PaymentSummary { get; set; }
        
        public PaymentStatus PaymentStatus { get; set; }
        public IEnumerable<PaymentUnity> PaymentUnities { get; set; }


    }
}
