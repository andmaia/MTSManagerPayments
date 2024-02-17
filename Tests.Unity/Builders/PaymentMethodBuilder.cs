using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class PaymentMethodBuilder
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        private string Name { get; set; } = $"PaymentMethod_{Guid.NewGuid()}";
        private DateTime CreatedDate { get; set; } = DateTime.Now;
        private DateTime LastUpdated { get; set; } = DateTime.MinValue;
        private DateTime FinishedDate { get; set; } = DateTime.MinValue;
        private bool IsActive { get; set; } = true;
        private float Tax { get; set; }
        private string PaymentMachineId { get; set; }
        private PaymentMachine PaymentMachine { get; set; }
        private IEnumerable<PaymentUnity> PaymentUnities { get; set; } = new List<PaymentUnity>();

        public PaymentMethodBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public PaymentMethodBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public PaymentMethodBuilder WithCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
            return this;
        }

        public PaymentMethodBuilder WithLastUpdated(DateTime lastUpdated)
        {
            LastUpdated = lastUpdated;
            return this;
        }

        public PaymentMethodBuilder WithFinishedDate(DateTime finishedDate)
        {
            FinishedDate = finishedDate;
            return this;
        }

        public PaymentMethodBuilder WithIsActive(bool isActive)
        {
            IsActive = isActive;
            return this;
        }

        public PaymentMethodBuilder WithTax(float tax)
        {
            Tax = tax;
            return this;
        }

        public PaymentMethodBuilder WithPaymentMachineId(string paymentMachineId)
        {
            PaymentMachineId = paymentMachineId;
            return this;
        }

        public PaymentMethodBuilder WithPaymentMachine(PaymentMachine paymentMachine)
        {
            PaymentMachine = paymentMachine;
            return this;
        }

        public PaymentMethodBuilder WithPaymentUnities(IEnumerable<PaymentUnity> paymentUnities)
        {
            PaymentUnities = paymentUnities;
            return this;
        }

        public PaymentMethodBuilder AddPaymentUnity(PaymentUnity paymentUnity)
        {
            ((List<PaymentUnity>)PaymentUnities).Add(paymentUnity);
            return this;
        }

        public PaymentMethod Build()
        {
            return new PaymentMethod(Id, PaymentMachineId, Name, CreatedDate, LastUpdated, FinishedDate, IsActive, Tax)
            {
                PaymentMachine = PaymentMachine,
                PaymentUnities = PaymentUnities
            };
        }
    }
}
