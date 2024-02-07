using Domain.DTO.Worker;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class WorkerCreateUserDTOValidator:AbstractValidator<WorkerCreateUserDTO>
    {
        public WorkerCreateUserDTOValidator() 
        {
            RuleFor(x => x.CredentialsId)
             .NotEmpty().WithMessage("CredentialsId cannot be empty.")
             .Length(36).WithMessage("CredentialsId must be a string with 36 characters.");

            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("CompanyId cannot be empty.")
                .Length(36).WithMessage("CompanyId must be a string with 36 characters.");

            RuleFor(x => x.Comission)
                .GreaterThan(0).WithMessage("Comission must be greater than zero.")
                .LessThan(100).WithMessage("Comission must be less than 100.");

         
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null.");
        }
    }
}
