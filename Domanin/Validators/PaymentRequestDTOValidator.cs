using Domain.DTO.Payment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class PaymentRequestDTOValidator : AbstractValidator<PaymentRequestDTO>
    {
        public PaymentRequestDTOValidator()
        {
            RuleFor(x => x.EntranceValue)
            .NotEmpty().WithMessage("Entrance value cannot be empty.")
            .GreaterThanOrEqualTo(0).WithMessage("Entrance value cannot be negative.");

            RuleFor(x => x.Value)
                .Null().WithMessage("Value must be null.")
                .GreaterThanOrEqualTo(0).WithMessage("Value cannot be negative.");

            RuleFor(x => x.PercentageDefault)
                .Null().WithMessage("Percentage default must be null.")
                .ExclusiveBetween(0, 100).WithMessage("Percentage default must be between 0 and 100.");

            RuleFor(x => x.PaymentSummaryId)
                .Null().WithMessage("PaymentSummaryId summary ID must be null.")
                .Length(36).WithMessage("PaymentSummaryId must be a string with 36 characters.");
        }
    }
}
