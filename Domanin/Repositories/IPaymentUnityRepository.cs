using CrossCutting.Enums;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPaymentUnityRepository
    {
        Task<string> CreatePaymentUnity(PaymentUnity data);
        Task<string> UpdatePaymentUnity(PaymentUnity data);
        Task<bool> DeletePaymentUnity(PaymentUnity data);
        Task<PaymentUnity> GetPaymentUnity(string id);

        Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByProcedure(string id);
        Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByPayment(string id);
        Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByWorker(string id);
        Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByPaymentMehod(string id);
        Task<IEnumerable<PaymentUnity>> GetAllPaymentUnityByPaymentMode(PaymentMode mode);


    }
}
