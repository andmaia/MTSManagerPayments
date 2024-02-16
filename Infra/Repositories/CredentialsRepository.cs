using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CredentialsRepository : ICredentialsRepository
    {

        private readonly DatabaseContext _databaseContext;
        
        public CredentialsRepository(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreateCredentials(Credentials data)
        {
                await _databaseContext.Credentials.AddAsync(data);
                _databaseContext.SaveChanges();
                return data.Id;
        }

        public async Task<Credentials> GetOneCredentialsById(string id)
        {
                Credentials result = await _databaseContext.Credentials.FindAsync(id);
                return result;
        }

        public async Task<string> UpdateCredentials(Credentials data)
        {
            try
            {
                _databaseContext.Credentials.Update(data);
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
