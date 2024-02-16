using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICompanyRepository
    {
        Task<string> CreateCompany(Company data);
        Task<string> UpdateCompany(Company data);
        Task<Company> GetOneCompanyById(string id);
    }
}
