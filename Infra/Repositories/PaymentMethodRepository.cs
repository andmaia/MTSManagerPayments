using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {

        private readonly DatabaseContext _databaseContext;

        public PaymentMethodRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        public async Task<string> CreatePaymentMethod(PaymentMethod data)
        {
            await _databaseContext.PaymentMethods.AddAsync(data);
            await _databaseContext.SaveChangesAsync();
            return data.Id;
        }

        public async Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodsByCompany(string id)
        {
            var paymentMethods =await _databaseContext.PaymentMethods
                .AsNoTracking().Where(c=>c.Id== id)
                .ToListAsync();

            return paymentMethods;
        }

        public async Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodsByMachine(string id)
        {
            var paymentMethods = await _databaseContext.PaymentMethods
                             .AsNoTracking().Where(c =>c.PaymentMachineId==id)
                             .ToListAsync();
        
            return paymentMethods;
        }

        public async Task<PaymentMethod> GetPaymentMethodById(string id)
        {
            var paymentMethod = await _databaseContext.PaymentMethods.FindAsync(id);
            return paymentMethod;
        }

        public async Task<string> UpdatePaymentMachine(PaymentMethod data)
        {
                _databaseContext.PaymentMethods.Update(data);
                await _databaseContext.SaveChangesAsync();
                return data.Id;
            
        }

      
    }
}
