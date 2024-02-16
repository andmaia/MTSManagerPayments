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
        public Payment(string id, DateTime createdDate, DateTime finishedDate, float percentageDefault, float value, float entranceValue)
        {
            Id = id;
            CreatedDate = createdDate;
            FinishedDate = finishedDate;
            PercentageDefault = percentageDefault;
            PaymentUnities = new List<PaymentUnity>();
            Value = value;
            EntranceValue = entranceValue;
        }

        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public float PercentageDefault { get; set; }
        public float Value { get; set; }
        public float EntranceValue { get; set; }
        
        public IEnumerable<PaymentUnity> PaymentUnities { get; set; }


    }
}
