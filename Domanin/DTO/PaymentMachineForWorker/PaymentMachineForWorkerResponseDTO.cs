using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.PaymentMachineForWorker
{
    public class PaymentMachineForWorkerResponseDTO
    {
        public string? Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public string? WorkerId { get; set; }
        public string? WorkerName{ get; set; }

        public string? PaymentMachineId { get; set; }
        public string? PaymentName { get; set; }

    }
}
