using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class PaymentMachineForWorkerBuilder
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        private DateTime CreatedDate { get; set; } = DateTime.Now;
        private DateTime FinishedDate { get; set; } = DateTime.MinValue;
        private DateTime UpdateDate { get; set; } = DateTime.MinValue;
        private bool IsActive { get; set; } = true;
        private string WorkerId { get; set; }
        private Worker Worker { get; set; }
        private string PaymentMachineId { get; set; }
        private PaymentMachine PaymentMachine { get; set; }

        public PaymentMachineForWorkerBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithFinishedDate(DateTime finishedDate)
        {
            FinishedDate = finishedDate;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithUpdateDate(DateTime updateDate)
        {
            UpdateDate = updateDate;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithIsActive(bool isActive)
        {
            IsActive = isActive;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithWorkerId(string workerId)
        {
            WorkerId = workerId;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithWorker(Worker worker)
        {
            Worker = worker;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithPaymentMachineId(string paymentMachineId)
        {
            PaymentMachineId = paymentMachineId;
            return this;
        }

        public PaymentMachineForWorkerBuilder WithPaymentMachine(PaymentMachine paymentMachine)
        {
            PaymentMachine = paymentMachine;
            return this;
        }

        public PaymentMachineForWorker Build()
        {
            return new PaymentMachineForWorker(Id, WorkerId, PaymentMachineId, CreatedDate, FinishedDate, UpdateDate, IsActive)
            {
                Worker = Worker,
                PaymentMachine = PaymentMachine
            };
        }
    }
}
