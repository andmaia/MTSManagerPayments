using CrossCutting.Enums;
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
    public class PaymentUnityRepository : IPaymentUnityRepository
    {


        private readonly DatabaseContext _databaseContext;
        public PaymentUnityRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreatePaymentUnity(PaymentUnity data)
        {

            await _databaseContext.PaymentUnities.AddAsync(data);
            await _databaseContext.SaveChangesAsync();
            return data.Id;
        }

        public async Task<bool> DeletePaymentUnity(PaymentUnity data)
        {

            try
            {
                _databaseContext.PaymentUnities.Remove(data);
                await _databaseContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
         
        }

        public async Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByPayment(string id)
        {
            var paymentsUnities =await _databaseContext.PaymentUnities
                .AsNoTracking().Where(x => x.PaymentId == id).ToListAsync();
            return paymentsUnities;
        }

        public async Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByPaymentMehod(string id)
        {
            var paymentsUnities = await _databaseContext.PaymentUnities
                .AsNoTracking().Where(x => x.PaymentMethodId== id).ToListAsync();
            return paymentsUnities;
        }

        public async Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByPaymentMode(PaymentMode mode)
        {
            var paymentsUnities = await _databaseContext.PaymentUnities
                .AsNoTracking().Where(x => x.PaymentMode == mode).ToListAsync();
            return paymentsUnities;
        }

        public async Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByProcedure(string id)
        {
           var paymentUnities = await _databaseContext.Procedures.AsNoTracking()
                     .Where(p => p.Id == id)
                    .SelectMany(p => p.Payment.PaymentUnities)
                    .ToListAsync();
            return paymentUnities;
        }

        public async Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByWorker(string id)
        {
            var paymentUnities = await _databaseContext.Procedures.AsNoTracking()
                   .Where(p => p.WorkerId == id)
                  .SelectMany(p => p.Payment.PaymentUnities)
                  .ToListAsync();
            return paymentUnities;
        }

        public async Task<PaymentUnity> GetPaymentUnity(string id)
        {
            var paymentUnity = await _databaseContext.PaymentUnities
                .FindAsync(id);
            return paymentUnity;
        }

        public async Task<string> UpdatePaymentUnity(PaymentUnity data)
        {
             _databaseContext.PaymentUnities.Update(data);
            await _databaseContext.SaveChangesAsync();
            return data.Id;
        }
    }
}
