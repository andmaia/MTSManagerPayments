using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class PaymentBuilder
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        private DateTime CreatedDate { get; set; } = DateTime.Now;
        private DateTime FinishedDate { get; set; } = DateTime.MinValue;
        private float PercentageDefault { get; set; } = 50.0f;
        private float Value { get; set; }
        private float EntranceValue { get; set; }
        private IEnumerable<PaymentUnity> PaymentUnities { get; set; } = new List<PaymentUnity>();

        public PaymentBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public PaymentBuilder WithCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
            return this;
        }

        public PaymentBuilder WithFinishedDate(DateTime finishedDate)
        {
            FinishedDate = finishedDate;
            return this;
        }

        public PaymentBuilder WithPercentageDefault(float percentageDefault)
        {
            PercentageDefault = percentageDefault;
            return this;
        }

        public PaymentBuilder WithValue(float value)
        {
            Value = value;
            return this;
        }

        public PaymentBuilder WithEntranceValue(float entranceValue)
        {
            EntranceValue = entranceValue;
            return this;
        }

        public PaymentBuilder WithPaymentUnities(IEnumerable<PaymentUnity> paymentUnities)
        {
            PaymentUnities = paymentUnities;
            return this;
        }

        public Payment Build()
        {
            return new Payment(Id, CreatedDate, FinishedDate, PercentageDefault, Value, EntranceValue)
            {
                PaymentUnities = PaymentUnities
            };
        }
    }
}
