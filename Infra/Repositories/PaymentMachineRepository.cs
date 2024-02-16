using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infra.Repositories
{
    public class PaymentMachineRepository : IPaymentMachinesRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PaymentMachineRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreatePaymentMachine(PaymentMachine data)
        {
            await _databaseContext.PaymentsMachines.AddAsync(data);
            await _databaseContext.SaveChangesAsync();
            return data.Id;
        }

        public async Task<IEnumerable<PaymentMachine>> GetAllPaymentMachineByCompany(string id)
        {
            var AllCompanys =await _databaseContext.PaymentsMachines
                .AsNoTracking()
                .Where(x => x.CompanyId == id)  
                .Include(x => x.PaymentsMethods)
                .ToListAsync();

            return AllCompanys;
        }

        public async Task<PaymentMachine> GetPaymentMachineById(string id)
        {
            var paymentMachine = await _databaseContext.PaymentsMachines
                 .AsNoTracking()
                 .Include(x => x.PaymentsMethods) 
                 .FirstOrDefaultAsync(x => x.Id == id);

            return paymentMachine;
        }

        public async Task<string> UpdatePaymentMachine(PaymentMachine data)
        {
             _databaseContext.PaymentsMachines.Update(data);
            await _databaseContext.SaveChangesAsync();
            return data.Id;
        }
    }
}
