using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentSummary
    {
        public string? Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public float TotalValue { get; set; }
        public float Entrace { get; set; }
        public bool EntraceAccount { get; set; }
        public float TotalTaxs { get; set; }
        public float TotalTaxToWorker { get; set; }
        public float TotalTaxToCompany { get; set; }
        public float ValueToCompanyReciver { get; set; }
        public float ValueToWorkerReciver { get; set; }
        public float ValueCompanyRecived { get; set; }
        public float ValueWorkerRecived { get; set; }
        public float RemainingValueToArtist { get; set; }
        public float RemaingValueToCompany { get; set; }
    }
}
