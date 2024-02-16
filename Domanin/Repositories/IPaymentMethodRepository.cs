using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPaymentMethodRepository
    {
        Task<string> CreatePaymentMethod(PaymentMethod data);
        Task<PaymentMethod> GetPaymentMethodById(string id);
        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodsByCompany(string id);
        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodsByMachine(string id);

        Task<string> UpdatePaymentMachine(PaymentMethod data);
    }
}
