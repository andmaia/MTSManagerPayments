using Domain.DTO.PaymentSummary;
using Domain.DTO.PaymentUnity;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Payment
{
    public class PaymentResponseDTO
    {
        public string? Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public float PercentageDefault { get; set; }
        public float Value { get; set; }
        public float EntranceValue { get; set; }
        public PaymentSummaruResponseDTO? PaymentSummary { get; set; }

        public IEnumerable<PaymentUnityResponseDTO>? PaymentUnities { get; set; }
    }
}
