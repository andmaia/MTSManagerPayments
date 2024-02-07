using Domain.DTO.PaymentMethod;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class PaymentMethodRequestDTOValidator : AbstractValidator<PaymentMethodRequestDTO>
    {
        public PaymentMethodRequestDTOValidator()
        {
            RuleFor(x => x.Tax)
                .NotNull().WithMessage("Tax cannot be null.")
                .GreaterThan(0).WithMessage("Tax must be greater than zero.");
            RuleFor(x => x.Name)
               .NotNull().WithMessage("Name cannot be null.");

            RuleFor(x => x.PaymentMachineId)
             .NotEmpty().WithMessage("PaymentMachineId cannot be empty.")
             .Length(36).WithMessage("PaymentMachineId must be a string with 36 characters.");
        }
    
    }
}
