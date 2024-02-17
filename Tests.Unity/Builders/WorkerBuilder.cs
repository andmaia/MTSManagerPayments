using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class WorkerBuilder
    {
        public WorkerBuilder(string id, string companyId, string credentialsId, string name, string? cpf, DateTime? birthDate, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive, float comission)
        {
            Id = id;
            CompanyId = companyId;
            CredentialsId = credentialsId;
            Name = name;
            Cpf = cpf;
            BirthDate = birthDate;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            Comission = comission;
        }

        private string Id { get; set; } = Guid.NewGuid().ToString();
        private string Name { get; set; } = $"Worker_{Guid.NewGuid().ToString().Substring(0, 10)}";
        private string? Cpf { get; set; }
        private DateTime? BirthDate { get; set; } = new DateTime(1990, 1, 1);  // Data de nascimento padrão
        private DateTime CreatedDate { get; set; } = DateTime.Now;
        private DateTime LastUpdated { get; set; } = DateTime.MinValue;
        private DateTime FinishedDate { get; set; } = DateTime.MinValue;
        private bool IsActive { get; set; } = true;
        private float Comission { get; set; } = 50.0f;
        private string CredentialsId { get; set; } = Guid.NewGuid().ToString();
        private string CompanyId { get; set; } = Guid.NewGuid().ToString();
        private IEnumerable<Procedure> Procedures { get; set; } = new List<Procedure>();
        private IEnumerable<PaymentMachineForWorker> PaymentMachineForWorkers { get; set; } = new List<PaymentMachineForWorker>();

        public WorkerBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public WorkerBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public WorkerBuilder WithCpf(string cpf)
        {
            Cpf = cpf;
            return this;
        }

        public WorkerBuilder WithBirthDate(DateTime? birthDate)
        {
            BirthDate = birthDate;
            return this;
        }

        public WorkerBuilder WithCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
            return this;
        }

        public WorkerBuilder WithLastUpdated(DateTime lastUpdated)
        {
            LastUpdated = lastUpdated;
            return this;
        }

        public WorkerBuilder WithFinishedDate(DateTime finishedDate)
        {
            FinishedDate = finishedDate;
            return this;
        }

        public WorkerBuilder WithIsActive(bool isActive)
        {
            IsActive = isActive;
            return this;
        }

        public WorkerBuilder WithComission(float comission)
        {
            Comission = comission;
            return this;
        }

        public WorkerBuilder WithCredentialsId(string credentialsId)
        {
            CredentialsId = credentialsId;
            return this;
        }

        public WorkerBuilder WithCompanyId(string companyId)
        {
            CompanyId = companyId;
            return this;
        }

        public WorkerBuilder WithProcedures(IEnumerable<Procedure> procedures)
        {
            Procedures = procedures;
            return this;
        }

        public WorkerBuilder WithPaymentMachineForWorkers(IEnumerable<PaymentMachineForWorker> paymentMachineForWorkers)
        {
            PaymentMachineForWorkers = paymentMachineForWorkers;
            return this;
        }

        public WorkerBuilder Build()
        {
            return new WorkerBuilder(Id, CompanyId, CredentialsId, Name, Cpf, BirthDate, CreatedDate, LastUpdated, FinishedDate, IsActive, Comission);

        }
    }

}
