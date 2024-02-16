using CrossCutting.Enums;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class PaymentSummaryRepository : IPaymentSummaryRepository
    {

        private readonly DatabaseContext _databaseContext;

        public PaymentSummaryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreatePaymentSummary(PaymentSummary paymentSummary)
        {
            await _databaseContext.PaymentsSummary.AddAsync(paymentSummary);
            await _databaseContext.SaveChangesAsync();
            return paymentSummary.Id;
        }

        public async Task<bool> DeletePaymentSummary(PaymentSummary paymentSummary)
        {
            try
            {
                _databaseContext.PaymentsSummary.Remove(paymentSummary);
                await _databaseContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<PaymentSummary>> GetAllPaymentSummariesByCompany(string id)
        {
           var paymentSummaries = await (
           from paymentSummary in _databaseContext.PaymentsSummary
           join payment in _databaseContext.Payments on paymentSummary.PaymentId equals payment.Id
           join procedure in _databaseContext.Procedures on payment.Id equals procedure.PaymentId
           join worker in _databaseContext.Workers on procedure.WorkerId equals worker.Id
           join company in _databaseContext.Companys on worker.CompanyId equals company.Id
           where company.Id == id
           select paymentSummary
       ).ToListAsync();

            return paymentSummaries;

        }

        public async Task<IEnumerable<PaymentSummary>> GetAllPaymentSummariesByPaymentStatus(string companyId,PaymentStatus paymentStatus)
        {
         var paymentSummaries = await(
         from paymentSummary in _databaseContext.PaymentsSummary
         join payment in _databaseContext.Payments on paymentSummary.PaymentId equals payment.Id
         join procedure in _databaseContext.Procedures on payment.Id equals procedure.PaymentId
         join worker in _databaseContext.Workers on procedure.WorkerId equals worker.Id
         join company in _databaseContext.Companys on worker.CompanyId equals company.Id
         where company.Id == companyId
         select paymentSummary
        ).Where(c=>c.PaymentStatus == paymentStatus).ToListAsync();

            return paymentSummaries;
        }

        public async Task<IEnumerable<PaymentSummary>> GetAllPaymentSummariesByWorker(string id)
        {
            var paymentSummaries = await(
       from paymentSummary in _databaseContext.PaymentsSummary
       join payment in _databaseContext.Payments on paymentSummary.PaymentId equals payment.Id
       join procedure in _databaseContext.Procedures on payment.Id equals procedure.PaymentId
       join worker in _databaseContext.Workers on procedure.WorkerId equals worker.Id
       where worker.Id == id
       select paymentSummary
      ).ToListAsync();

            return paymentSummaries;
        }

        public async Task<PaymentSummary> GetPaymentSummaryById(string id)
        {
            var paymmentSummary = await _databaseContext.PaymentsSummary.FindAsync(id);
            return paymmentSummary;
        }

        public async Task<PaymentSummary> GetPaymentSummaryPaymentId(string id)
        {
            var paymentSummaries = await _databaseContext.PaymentsSummary
                .FirstOrDefaultAsync(x=>x.PaymentId == id);

            return paymentSummaries;
        }

        public async Task<string> UpdatePaymentSummary(PaymentSummary paymentSummary)
        {
             _databaseContext.PaymentsSummary.Update(paymentSummary);
            await _databaseContext.SaveChangesAsync();
            return paymentSummary.Id;
        }
    }
}
