using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class PaymentMachineBuilder
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        private string Name { get; set; } = $"PaymentMachineBuild_{Guid.NewGuid()}";
        private DateTime CreatedDate { get; set; } = DateTime.Now;
        private DateTime LastUpdated { get; set; } = DateTime.MinValue;
        private DateTime FinishedDate { get; set; } = DateTime.MinValue;
        private bool IsActive { get; set; } = true;
        private string CompanyId { get; set; }
        private Company Company { get; set; }
        private IEnumerable<PaymentMethod> PaymentsMethods { get; set; } = new List<PaymentMethod>();
        private IEnumerable<PaymentMachineForWorker> PaymentMachineForWorkers { get; set; } = new List<PaymentMachineForWorker>();

        public PaymentMachineBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public PaymentMachineBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public PaymentMachineBuilder WithCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
            return this;
        }

        public PaymentMachineBuilder WithLastUpdated(DateTime lastUpdated)
        {
            LastUpdated = lastUpdated;
            return this;
        }

        public PaymentMachineBuilder WithFinishedDate(DateTime finishedDate)
        {
            FinishedDate = finishedDate;
            return this;
        }

        public PaymentMachineBuilder WithIsActive(bool isActive)
        {
            IsActive = isActive;
            return this;
        }

        public PaymentMachineBuilder WithCompanyId(string companyId)
        {
            CompanyId = companyId;
            return this;
        }

        public PaymentMachineBuilder WithCompany(Company company)
        {
            Company = company;
            return this;
        }

        public PaymentMachineBuilder WithPaymentsMethods(IEnumerable<PaymentMethod> paymentMethods)
        {
            PaymentsMethods = paymentMethods;
            return this;
        }

        public PaymentMachineBuilder WithPaymentMachineForWorkers(IEnumerable<PaymentMachineForWorker> paymentMachineForWorkers)
        {
            PaymentMachineForWorkers = paymentMachineForWorkers;
            return this;
        }

        public PaymentMachine Build()
        {
            return new PaymentMachine(Id, CompanyId, Name, CreatedDate, LastUpdated, FinishedDate, IsActive)
            {
                Company = Company,
                PaymentsMethods = PaymentsMethods,
                PaymentMachineForWorkers = PaymentMachineForWorkers
            };
        }
    }
}
