using CrossCutting.Helpers;
using Domain.DTO.PaymentMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IPaymentMachineService
    {
        Task<ResultService<string>> CreatePaymentMachine(PaymentMachineRequestDTO data);
        Task<ResultService<string>> UpdatePaymentMachine(PaymentMachineRequestDTO data);
        Task<ResultService<IEnumerable<PaymentMachineResponseDTO>>> GetAllPaymentMachineByCompany(string id);
        Task<ResultService<PaymentMachineResponseDTO>> GetPaymentMachine(string id);
        Task<ResultService<string>> Disable(string id);
        Task<ResultService<string>> Enable(string id);

    }
}
