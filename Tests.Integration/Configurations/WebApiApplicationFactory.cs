using Infra;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.Common;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MySqlConnector;

namespace Tests.Integration.Configurations
{
    public class WebApiApplicationFactory : WebApplicationFactory<Program>
    {
        private readonly TestDatabase _database;
        private string _connectionTests;
        public WebApiApplicationFactory()
        {
            _connectionTests = "server=localhost;port=3306;uid=root;pwd=andrew71;database=managerpaytests4";
            _database = new TestDatabase(_connectionTests);
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {

            builder.ConfigureServices(services =>
            {
                var dbContextDescriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<DatabaseContext>));

                services.Remove(dbContextDescriptor);

                services.AddDbContext<DatabaseContext>(options =>
                {
                    options.UseMySql(_connectionTests, ServerVersion.AutoDetect(_connectionTests));
                });

                var dbConnectionDescriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbConnection));

                services.Remove(dbConnectionDescriptor);

                services.AddSingleton<DbConnection>(container =>
                {
                    var connection = _database.CreateContext().Database.GetDbConnection();
                    connection.Open();
                    return connection;
                });
            });

            builder.UseEnvironment("Development");

        }
    }
}
