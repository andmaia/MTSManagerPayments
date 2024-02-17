using CrossCutting.Enums;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class PaymentUnityBuilder
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        private float Value { get; set; } = 0.0f;
        private float ArtistPercentage { get; set; } = 0.0f;
        private PaymentMode PaymentMode { get; set; }
        private float ValueToArtist { get; set; } = 0.0f;
        private float ValueWithTax { get; set; } = 0.0f;
        private float CurrentTax { get; set; } = 0.0f;
        private float TotalTax { get; set; } = 0.0f;
        private float ValueToCompany { get; set; } = 0.0f;
        private string PaymentId { get; set; }
        private Payment Payment { get; set; }
        private PaymentMethod PaymentMethod { get; set; }
        private string PaymentMethodId { get; set; }

        public PaymentUnityBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public PaymentUnityBuilder WithValue(float value)
        {
            Value = value;
            return this;
        }

        public PaymentUnityBuilder WithArtistPercentage(float artistPercentage)
        {
            ArtistPercentage = artistPercentage;
            return this;
        }

        public PaymentUnityBuilder WithPaymentMode(PaymentMode paymentMode)
        {
            PaymentMode = paymentMode;
            return this;
        }

        public PaymentUnityBuilder WithValueToArtist(float valueToArtist)
        {
            ValueToArtist = valueToArtist;
            return this;
        }

        public PaymentUnityBuilder WithValueWithTax(float valueWithTax)
        {
            ValueWithTax = valueWithTax;
            return this;
        }

        public PaymentUnityBuilder WithCurrentTax(float currentTax)
        {
            CurrentTax = currentTax;
            return this;
        }

        public PaymentUnityBuilder WithTotalTax(float totalTax)
        {
            TotalTax = totalTax;
            return this;
        }

        public PaymentUnityBuilder WithValueToCompany(float valueToCompany)
        {
            ValueToCompany = valueToCompany;
            return this;
        }

        public PaymentUnityBuilder WithPaymentId(string paymentId)
        {
            PaymentId = paymentId;
            return this;
        }

        public PaymentUnityBuilder WithPaymentMethod(PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
            return this;
        }

        public PaymentUnityBuilder WithPaymentMethodId(string paymentMethodId)
        {
            PaymentMethodId = paymentMethodId;
            return this;
        }

        public PaymentUnity Build()
        {
            return new PaymentUnity(Id, PaymentId, PaymentMethodId, Value, ArtistPercentage, PaymentMode, ValueToArtist, ValueWithTax, TotalTax, ValueToCompany)
            {
                Payment =Payment,
                PaymentMethod = PaymentMethod
            };
        }
    }
}
