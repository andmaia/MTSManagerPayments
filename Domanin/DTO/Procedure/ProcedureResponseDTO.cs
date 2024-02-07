using Domain.DTO.Worker;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Procedure
{
    public class ProcedureResponseDTO
    {
        public string? Id { get; set; }
        public string? CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }

        public WorkerResponseDTO Worker { get; set; }
        public PaymentResponseDTO Payment { get; set; }
    }
}
