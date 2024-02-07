using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Worker
    {
        public Worker(string id, string name, string cpf, DateTime birthDate, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive, float comission, Credentials credentials,Company company)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            BirthDate = birthDate;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            Comission = comission;
            Credentials = credentials;
            Company = company;
            Procedures = new List<Procedure>();
            paymentMachineForWorkers = new List<PaymentMachineForWorker>();
        }

        public string Id { get; set; }  
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate {  get; set; }
        public bool IsActive { get; set; }
        public float Comission {  get; set; }
        public Credentials Credentials { get; set; }
        public Company Company { get; set; }

        public IEnumerable<Procedure> Procedures { get; set; }

        public IEnumerable<PaymentMachineForWorker> paymentMachineForWorkers { get; set; }

    }
}
 