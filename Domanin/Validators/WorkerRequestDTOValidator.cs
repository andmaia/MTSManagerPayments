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
    public class WorkerRequestDTOValidator:AbstractValidator<WorkerRequestDTO>
    {
        public WorkerRequestDTOValidator()
        {
            RuleFor(x => x.CredentialsId)
                .NotEmpty().WithMessage("CredentialsId cannot be empty.")
                .Length(36).WithMessage("CredentialsId must be a string with 36 characters.");

            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("CompanyId cannot be empty.")
                .Length(36).WithMessage("CompanyId must be a string with 36 characters.");

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
