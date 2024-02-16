using CrossCutting.Enums;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPaymentSummaryRepository
    {
        Task<string> CreatePaymentSummary(PaymentSummary paymentSummary);
        Task<string> UpdatePaymentSummary(PaymentSummary paymentSummary);
        Task<bool> DeletePaymentSummary(PaymentSummary paymentSummary);
        Task<PaymentSummary> GetPaymentSummaryById(string id);
        Task<PaymentSummary> GetPaymentSummaryPaymentId(string id);
        Task<IEnumerable<PaymentSummary>> GetAllPaymentSummariesByWorker(string id);
        Task<IEnumerable<PaymentSummary>> GetAllPaymentSummariesByPaymentStatus(string companyId,PaymentStatus paymentStatus);
        Task<IEnumerable<PaymentSummary>> GetAllPaymentSummariesByCompany(string id);


    }
}
