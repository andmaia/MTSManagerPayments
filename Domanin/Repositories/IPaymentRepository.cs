using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPaymentRepository
    {
        Task<Payment> GetPaymentById  (string id);
        Task<string> CreatePayment(Payment payment);
        Task<string> UpdatePayment(Payment payment);
        Task<bool> DeletePayment(Payment data);
    }
}
