using CrossCutting.Enums;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class PaymentSummaryBuilder
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        private string PaymentId { get; set; } = Guid.NewGuid().ToString();
        private Payment Payment { get; set; }
        private DateTime CreatedDate { get; set; } = DateTime.Now;
        private DateTime FinishedDate { get; set; } = DateTime.MinValue;
        private DateTime UpdatedDate { get; set; } = DateTime.MinValue;
        private DateTime PaidDate { get; set; }
        private bool IsActive { get; set; } = true;
        private string PaymentReceiptURL { get; set; } = "https://example.com/payment-receipt";
        private float TotalValue { get; set; } = 0.0f;
        private float Entrace { get; set; } = 0.0f;
        private bool EntraceAccount { get; set; } = false;
        private float TotalTaxs { get; set; } = 0.0f;
        private float TotalTaxToWorker { get; set; } = 0.0f;
        private float TotalTaxToCompany { get; set; } = 0.0f;
        private float ValueToCompanyReciver { get; set; } = 0.0f;
        private float ValueToWorkerReciver { get; set; } = 0.0f;
        private float ValueCompanyRecived { get; set; } = 0.0f;
        private float ValueWorkerRecived { get; set; } = 0.0f;
        private float RemainingValueToArtist { get; set; } = 0.0f;
        private float RemaingValueToCompany { get; set; } = 0.0f;
        private PaymentStatus PaymentStatus { get; set; }

        public PaymentSummaryBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public PaymentSummaryBuilder WithPaymentId(string paymentId)
        {
            PaymentId = paymentId;
            return this;
        }

        public PaymentSummaryBuilder WithPayment(Payment payment)
        {
            Payment = payment;
            return this;
        }

        public PaymentSummaryBuilder WithCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
            return this;
        }

        public PaymentSummaryBuilder WithFinishedDate(DateTime finishedDate)
        {
            FinishedDate = finishedDate;
            return this;
        }

        public PaymentSummaryBuilder WithUpdatedDate(DateTime updatedDate)
        {
            UpdatedDate = updatedDate;
            return this;
        }

        public PaymentSummaryBuilder WithPaidDate(DateTime paidDate)
        {
            PaidDate = paidDate;
            return this;
        }

        public PaymentSummaryBuilder WithIsActive(bool isActive)
        {
            IsActive = isActive;
            return this;
        }

        public PaymentSummaryBuilder WithPaymentReceiptURL(string paymentReceiptURL)
        {
            PaymentReceiptURL = paymentReceiptURL;
            return this;
        }

        public PaymentSummaryBuilder WithTotalValue(float totalValue)
        {
            TotalValue = totalValue;
            return this;
        }

        public PaymentSummaryBuilder WithEntrace(float entrace)
        {
            Entrace = entrace;
            return this;
        }

        public PaymentSummaryBuilder WithEntraceAccount(bool entraceAccount)
        {
            EntraceAccount = entraceAccount;
            return this;
        }

        public PaymentSummaryBuilder WithTotalTaxs(float totalTaxs)
        {
            TotalTaxs = totalTaxs;
            return this;
        }

        public PaymentSummaryBuilder WithTotalTaxToWorker(float totalTaxToWorker)
        {
            TotalTaxToWorker = totalTaxToWorker;
            return this;
        }

        public PaymentSummaryBuilder WithTotalTaxToCompany(float totalTaxToCompany)
        {
            TotalTaxToCompany = totalTaxToCompany;
            return this;
        }

        public PaymentSummaryBuilder WithValueToCompanyReciver(float valueToCompanyReciver)
        {
            ValueToCompanyReciver = valueToCompanyReciver;
            return this;
        }

        public PaymentSummaryBuilder WithValueToWorkerReciver(float valueToWorkerReciver)
        {
            ValueToWorkerReciver = valueToWorkerReciver;
            return this;
        }

        public PaymentSummaryBuilder WithValueCompanyRecived(float valueCompanyRecived)
        {
            ValueCompanyRecived = valueCompanyRecived;
            return this;
        }

        public PaymentSummaryBuilder WithValueWorkerRecived(float valueWorkerRecived)
        {
            ValueWorkerRecived = valueWorkerRecived;
            return this;
        }

        public PaymentSummaryBuilder WithRemainingValueToArtist(float remainingValueToArtist)
        {
            RemainingValueToArtist = remainingValueToArtist;
            return this;
        }

        public PaymentSummaryBuilder WithRemaingValueToCompany(float remaingValueToCompany)
        {
            RemaingValueToCompany = remaingValueToCompany;
            return this;
        }

        public PaymentSummaryBuilder WithPaymentStatus(PaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus;
            return this;
        }

        public PaymentSummary Build()
        {
            return new PaymentSummary(PaymentReceiptURL, PaymentStatus, PaymentId)
            {
                Id = Id,
                Payment = Payment,
                CreatedDate = CreatedDate,
                FinishedDate = FinishedDate,
                UpdatedDate = UpdatedDate,
                PaidDate = PaidDate,
                IsActive = IsActive,
                TotalValue = TotalValue,
                Entrace = Entrace,
                EntraceAccount = EntraceAccount,
                TotalTaxs = TotalTaxs,
                TotalTaxToWorker = TotalTaxToWorker,
                TotalTaxToCompany = TotalTaxToCompany,
                ValueToCompanyReciver = ValueToCompanyReciver,
                ValueToWorkerReciver = ValueToWorkerReciver,
                ValueCompanyRecived = ValueCompanyRecived,
                ValueWorkerRecived = ValueWorkerRecived,
                RemainingValueToArtist = RemainingValueToArtist,
                RemaingValueToCompany = RemaingValueToCompany,
                PaymentStatus = PaymentStatus
            };
        }
    }
}
