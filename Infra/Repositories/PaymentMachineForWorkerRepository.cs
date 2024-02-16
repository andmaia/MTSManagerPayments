using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class PaymentMachineForWorkerRepository:IPaymentMachineForWorkerRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PaymentMachineForWorkerRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreatePaymentMachineForWorker(PaymentMachineForWorker paymentMachineForWorker)
        {
            await _databaseContext.paymentMachineForWorkers.AddAsync(paymentMachineForWorker);
            await _databaseContext.SaveChangesAsync();
            return paymentMachineForWorker.Id;
        }

        public async Task<IEnumerable<PaymentMachineForWorker>> GetAllPaymentMachineForWorkersByCompany(string companyId)
        {
            var allPaymentMachinesForWorkersByCompany =await _databaseContext.paymentMachineForWorkers
                .AsNoTracking().Where(pmfw => pmfw.PaymentMachine.CompanyId == companyId).ToListAsync();

            return allPaymentMachinesForWorkersByCompany;
        }

        public async Task<PaymentMachineForWorker> GetPaymentMachineForWorkerById(string id)
        {
            var paymentMachineForWorker = await _databaseContext.paymentMachineForWorkers.FindAsync(id);
            return paymentMachineForWorker;
        }

        public async Task<IEnumerable<PaymentMachineForWorker>> GetPaymentMachineForWorkersByMachine(string machineId, bool isActive = true)
        {
            var allPaymentMachinesForWorkersByMachine = await _databaseContext.paymentMachineForWorkers
               .AsNoTracking().Where(pmfw => pmfw.PaymentMachineId ==machineId && pmfw.IsActive == isActive).ToListAsync();

            return allPaymentMachinesForWorkersByMachine;
        }

        public async Task<IEnumerable<PaymentMachineForWorker>> GetPaymentMachineForWorkersByMWorker(string workId, bool isActive = true)
        {
            var allPaymentMachinesForWorkersByWorker = await _databaseContext.paymentMachineForWorkers
          .AsNoTracking().Where(pmfw => pmfw.WorkerId == workId && pmfw.IsActive == isActive).ToListAsync();

            return allPaymentMachinesForWorkersByWorker;
        }

        public async Task<string> UpdatePaymentMachineForWorker(PaymentMachineForWorker paymentMachineForWorker)
        {

             _databaseContext.paymentMachineForWorkers.Update(paymentMachineForWorker);
            await _databaseContext.SaveChangesAsync();
            return paymentMachineForWorker.Id;
        }
    }
}
