using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company
    {
        public Company(string id, string name, string cnpj, DateTime createdDate, DateTime lastUpdated, DateTime finishedDate, bool isActive, Credentials credentials)
        {
            Id = id;
            Name = name;
            Cnpj = cnpj;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FinishedDate = finishedDate;
            IsActive = isActive;
            Credentials = credentials;
            Workers = new List<Worker> ();
            PaymentMachines = new List<PaymentMachine> ();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }
        public Credentials Credentials { get; set; }
        public IEnumerable<Worker> Workers { get; set; }
        public IEnumerable<PaymentMachine> PaymentMachines { get; set; }
    }
}
