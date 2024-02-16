using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.PaymentSummary
{
    public class PaymentSummaryRequestDTO
    {
        public string? PaymentReceiptURL { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public string? PaymentId { get; set; }
    }
}
