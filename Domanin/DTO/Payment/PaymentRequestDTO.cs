using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Payment
{
    public class PaymentRequestDTO
    {
        public float PercentageDefault { get; set; }
        public float Value { get; set; }
        public float EntranceValue { get; set; }
        public string?  PaymentSummaryId { get; set; }

    }
}
