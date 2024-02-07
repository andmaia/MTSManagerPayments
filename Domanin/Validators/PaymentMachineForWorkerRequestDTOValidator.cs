using Domain.DTO.PaymentMachine;
using Domain.DTO.PaymentMachineForWork;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class PaymentMachineForWorkerRequestDTOValidator : AbstractValidator<PaymentMachineForWorkerRequestDTO>
    {
        public PaymentMachineForWorkerRequestDTOValidator()
        {
            RuleFor(x => x.IsActive).NotEmpty().WithMessage("Active status can not be empty");
            RuleFor(x => x.PaymentMachineId)
             .NotEmpty().WithMessage("PaymentMachineId cannot be empty.")
             .Length(36).WithMessage("PaymentMachineId must be a string with 36 characters.");
            RuleFor(x => x.WorkerId)
              .NotEmpty().WithMessage("WorkerId cannot be empty.")
              .Length(36).WithMessage("WorkerId must be a string with 36 characters.");
        }
    }
}
