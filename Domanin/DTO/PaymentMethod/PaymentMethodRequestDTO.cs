using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.PaymentMethod
{
    public class PaymentMethodRequestDTO
    {
        public string? Name { get; set; }
        public float Tax { get; set; }
        public string? PaymentMachineId { get; set; }
    }
}
