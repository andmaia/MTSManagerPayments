using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {

        private readonly DatabaseContext _databaseContext;

        public CompanyRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreateCompany(Company data)
        {
            await _databaseContext.Companys.AddAsync(data);
            _databaseContext.SaveChanges();
            return data.Id;
        }

        public async  Task<Company> GetOneCompanyById(string id)
        {
            Company result = await _databaseContext.Companys.FindAsync(id);
            return result;
        }

        public  async Task<string> UpdateCompany(Company data)
        {
            try
            {
                _databaseContext.Companys.Update(data);
                await _databaseContext.SaveChangesAsync();
                return data.Id;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
