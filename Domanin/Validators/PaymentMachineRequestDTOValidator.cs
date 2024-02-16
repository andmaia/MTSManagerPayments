using Domain.DTO.PaymentMachine;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class PaymentMachineRequestDTOValidator:AbstractValidator<PaymentMachineRequestDTO>
    {
        public PaymentMachineRequestDTOValidator() 
        {
            RuleFor(x => x.Name)
               .NotNull().WithMessage("Name cannot be null.");

            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("CompanyId cannot be empty.")
                .Length(36).WithMessage("CompanyId must be a string with 36 characters.");

        } 
    }
}
