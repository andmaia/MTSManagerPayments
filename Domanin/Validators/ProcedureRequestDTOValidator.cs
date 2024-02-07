using Domain.DTO.Procedure;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class ProcedureRequestDTOValidator:AbstractValidator<ProcedureRequestDTO>
    {
        public ProcedureRequestDTOValidator() 
        {
            RuleFor(x => x.PaymentId)
                 .NotEmpty().WithMessage("PaymentId cannot be empty.")
                 .Length(36).WithMessage("PaymentId must be a string with 36 characters.");
            RuleFor(x => x.WorkerId)
               .NotEmpty().WithMessage("WorkerId cannot be empty.")
               .Length(36).WithMessage("WorkerId must be a string with 36 characters.");

        }
    }
}
