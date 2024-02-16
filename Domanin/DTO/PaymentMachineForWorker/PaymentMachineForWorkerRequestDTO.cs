using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.PaymentMachineForWork
{
    public class PaymentMachineForWorkerRequestDTO
    {
        public bool IsActive { get; set; }
        public string? WorkerId { get; set; }
        public string? PaymentMachineId { get; set; }
    }
}
