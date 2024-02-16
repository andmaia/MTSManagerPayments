using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infra.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PaymentRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreatePayment(Payment payment)
        {
            await _databaseContext.Payments.AddAsync(payment);
            await _databaseContext.SaveChangesAsync();
            return payment.Id;
        }

      

        public async Task<bool> DeletePayment(Payment data)
        {
            try
            {
                _databaseContext.Payments.Remove(data);
                await _databaseContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
             }

        }

        public async Task<Payment> GetPaymentById(string id)
        {
            var payment = await  _databaseContext.Payments.FindAsync(id);
            return payment;
        }

        public async Task<string> UpdatePayment(Payment payment)
        {
             _databaseContext.Payments.Update(payment);
            await _databaseContext.SaveChangesAsync();
            return payment.Id;
        }
    }
}
