using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.PaymentUnity
{
    public class PaymentUnityRequestDTO
    {
        public float Value { get; set; }
        public float ArtistPercentage { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public string? PaymentId { get; set; }

        public string? PaymentMethodId { get; set; }
    }
}
