using CrossCutting.Helpers;
using Domain.DTO.Worker;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class WorkerUpdateDTOValidator:AbstractValidator<WorkerUpdateDTO>
    {
        public WorkerUpdateDTOValidator() 
        {
            RuleFor(x => x.Comission)
               .GreaterThan(0).WithMessage("Comission must be greater than zero.")
               .LessThan(100).WithMessage("Comission must be less than 100.");
            RuleFor(x => x.BirthDate)
               .Must(DateValidator.BeAValidDate).WithMessage("BirthDate cannot be greater than today.");
            RuleFor(x => x.Name)
               .NotNull().WithMessage("Name cannot be null.");
            RuleFor(x => x.Cpf)
               .Matches(@"^\d+$").WithMessage("The cpf field can only contain digits.")
               .Must(DocumentValidator.IsValidCpf).WithMessage("The cpf field is not a valid Cpf.")
               .When(x => !string.IsNullOrWhiteSpace(x.Cpf));
        }
    }
}
