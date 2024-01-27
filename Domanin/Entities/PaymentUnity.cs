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
        public PaymentUnity(string id, float value, float artistPercentage, PaymentMode paymentMode, float valueToArtist, float valueWithTax, float totalTax, float valueToCompany, Payment payment)
        {
            Id = id;
            Value = value;
            ArtistPercentage = artistPercentage;
            PaymentMode = paymentMode;
            ValueToArtist = valueToArtist;
            ValueWithTax = valueWithTax;
            TotalTax = totalTax;
            ValueToCompany = valueToCompany;
            Payment = payment;
        }

        public string Id { get; set; }
        public float Value { get; set; }
        public float ArtistPercentage { get; set; }
        public PaymentMode PaymentMode { get; set; }    
        public float ValueToArtist { get; set; }
        public float ValueWithTax { get; set; }
        public float TotalTax { get; set; }
        public float ValueToCompany { get; set; }
        public Payment Payment { get; set; }   

    }
}
