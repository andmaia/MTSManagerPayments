using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentUnity
    {
        public PaymentUnity(string id,string paymentId,string paymentMethodId, float value, float artistPercentage, PaymentMode paymentMode, float valueToArtist, float valueWithTax, float totalTax, float valueToCompany)
        {
            Id = id;
            Value = value;
            ArtistPercentage = artistPercentage;
            PaymentMode = paymentMode;
            ValueToArtist = valueToArtist;
            ValueWithTax = valueWithTax;
            TotalTax = totalTax;
            ValueToCompany = valueToCompany;
            PaymentId = paymentId;
            PaymentMethodId = paymentMethodId;
        }

        public string Id { get; set; }
        public float Value { get; set; }
        public float ArtistPercentage { get; set; }
        public PaymentMode PaymentMode { get; set; }    
        public float ValueToArtist { get; set; }
        public float ValueWithTax { get; set; }
        public float CurrentTax { get; set; }

        public float TotalTax { get; set; }
        public float ValueToCompany { get; set; }
        public string PaymentId { get; set; }
        public Payment? Payment { get; set; }
        public string PaymentMethodId { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }

    }
}
