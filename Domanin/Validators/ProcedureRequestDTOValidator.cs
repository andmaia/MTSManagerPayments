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
         
            RuleFor(x => x.WorkerId)
               .NotEmpty().WithMessage("WorkerId cannot be empty.")
               .Length(36).WithMessage("WorkerId must be a string with 36 characters.");
            RuleFor(x => x.CustomerName)
                .NotEmpty().WithMessage("The name can not be empty");

        }
    }
}
