using Domain.DTO.PaymentSummary;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class PaymentSummaryRequestDTOValidator:AbstractValidator<PaymentSummaryRequestDTO>
    {
        public PaymentSummaryRequestDTOValidator()
        {
            RuleFor(x => x.PaymentReceiptURL)
                .NotEmpty()
                .WithMessage("The ReceiptUrl can not be");
            RuleFor(x => x.PaymentStatus)
                .IsInEnum().WithMessage("Must be a PaymentStatus");
            RuleFor(x => x.PaymentId)
                .Length(36).WithMessage("The payment is invalid ");
        }
    }
}
