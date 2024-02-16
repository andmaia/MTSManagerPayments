using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.PaymentUnity
{
    public class PaymentUnityResponseDTO
    {
        public string? Id { get; set; }
        public float Value { get; set; }
        public float ArtistPercentage { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public float ValueToArtist { get; set; }
        public float ValueWithTax { get; set; }
        public float TotalTax { get; set; }
        public float ValueToCompany { get; set; }
        public string? PaymentId { get; set; }

        public string? PaymentMethodId { get; set; }
    }
}
