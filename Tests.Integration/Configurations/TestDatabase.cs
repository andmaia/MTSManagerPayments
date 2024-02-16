using Domain.Entities;
using Infra;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

public class TestDatabase
{
    private static readonly object _lock = new();
    private bool _databaseInitialized;
    private string _connectionTests;
    public TestDatabase(string connectionTedts)
    {
        _connectionTests = connectionTedts;
        lock (_lock)
        {
            if (!_databaseInitialized)
            {
                using (var context = CreateContext())
                {
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    var credentials = new Credentials
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = "test@example.com",
                        Password = "password",
                        Permission = CrossCutting.Enums.Permission.MANAGER
                    };

                    var company = new Company(
                        id: "d47c04d8-7fca-4b38-a9f8-378ea1a20222",
                        credentialsId: credentials.Id,
                        name: "CompanyTest",
                        cnpj: "47447516000142",
                        createdDate: DateTime.Now,
                        lastUpdated: DateTime.Now,
                        finishedDate: DateTime.MinValue,
                        isActive: true
                    );
                    var credentials1 = new Credentials
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = "worker1@example.com",
                        Password = "password1",
                        Permission = CrossCutting.Enums.Permission.ARTIST
                    };

                    var credentials2 = new Credentials
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = "worker2@example.com",
                        Password = "password2",
                        Permission = CrossCutting.Enums.Permission.ARTIST
                    };

                    var credentials3 = new Credentials
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = "worker3@example.com",
                        Password = "password3",
                        Permission = CrossCutting.Enums.Permission.ARTIST
                    };

                    var credentials4 = new Credentials
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = "worker4@example.com",
                        Password = "password4",
                        Permission = CrossCutting.Enums.Permission.ARTIST
                    };

                var workers = new List<Worker>
                {
                    new Worker(
                        id: Guid.NewGuid().ToString(),
                        companyId: company.Id,
                        credentialsId: credentials1.Id,
                        name: "Worker1",
                        cpf: "11122233344",
                        createdDate: DateTime.Now,
                        lastUpdated: DateTime.Now,
                        finishedDate: DateTime.MinValue,
                        isActive: true,
                        comission: 0.1f
                    )
                    {
                        Credentials = credentials1
                    },
                    new Worker(
                        id: Guid.NewGuid().ToString(),
                        companyId: company.Id,
                        credentialsId: credentials2.Id,
                        name: "Worker2",
                        cpf: "22233344455",
                        createdDate: DateTime.Now,
                        lastUpdated: DateTime.Now,
                        finishedDate: DateTime.MinValue,
                        isActive: true,
                        comission: 0.2f
                    )
                    {
                        Credentials = credentials2
                    },
                    new Worker(
                        id: Guid.NewGuid().ToString(),
                        companyId: company.Id,
                        credentialsId: credentials3.Id,
                        name: "Worker3",
                        cpf: "33344455566",
                        createdDate: DateTime.Now,
                        lastUpdated: DateTime.Now,
                        finishedDate: DateTime.MinValue,
                        isActive: false,
                        comission: 0.3f
                    )
                    {
                        Credentials = credentials3
                    },
                    new Worker(
                        id: "2cb9e432-001e-4f05-98a5-dfaae11bda0a",
                        companyId: company.Id,
                        credentialsId: credentials4.Id,
                        name: "Worker4",
                        cpf: "44455566677",
                        createdDate: DateTime.Now,
                        lastUpdated: DateTime.Now,
                        finishedDate: DateTime.MinValue,
                        isActive: true,
                        comission: 0.4f
                    )
                    {
                        Credentials = credentials4
                    }
                };
                    company.Workers = workers;
                    context.Add(credentials );
                    context.Add(company);

                    context.SaveChanges();

                }

                _databaseInitialized = true;
                            }
                        }
    }

    public DatabaseContext CreateContext()
    {
        return new DatabaseContext(
            new DbContextOptionsBuilder<DatabaseContext>()
                .UseMySql(_connectionTests, ServerVersion.AutoDetect(_connectionTests))
                .Options);
    }

}
