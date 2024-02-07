using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.PaymentMethod
{
    public class PaymentMethodResponseDTO
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }
        public float Tax { get; set; }
        public string? PaymentMachineId{ get; set; }
    }
}
