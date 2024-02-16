using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPaymentMachinesRepository
    {
        Task<string> CreatePaymentMachine(PaymentMachine data);
        Task<PaymentMachine> GetPaymentMachineById(string id);
        Task<IEnumerable<PaymentMachine>> GetAllPaymentMachineByCompany(string id);
        Task<string> UpdatePaymentMachine(PaymentMachine data);

    }
}
