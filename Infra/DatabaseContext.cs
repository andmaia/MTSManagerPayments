using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Credentials> Credentials { get; set; }
       public DbSet<Worker> Workers { get; set; }
       public DbSet<Company> Companys { get; set; }   
       public DbSet<Procedure> Procedures { get; set; }
       public DbSet<Payment> Payments { get; set; }
       public DbSet<PaymentSummary> PaymentsSummary { get; set; }
       public DbSet<PaymentMachine> PaymentsMachines { get; set;}
       public DbSet<PaymentMethod> PaymentMethods { get; set; }
       public DbSet<PaymentUnity> PaymentUnities { get; set; }
       public DbSet<PaymentMachineForWorker> paymentMachineForWorkers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credentials>(ec =>
            {
                ec.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20);

                ec.Property(e => e.Permission)
                    .IsRequired();
            });

            modelBuilder.Entity<Company>(ec =>
            {
                ec.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnType("varchar(14)");

                ec.Property(e => e.IsActive)
                    .IsRequired();

                ec.Property(e => e.Name)
                    .IsRequired();
            });

            modelBuilder.Entity<Worker>(ec =>
            {
                ec.Property(e => e.Cpf)
                    .HasColumnType("varchar(11)")
                    .HasMaxLength(11);
            });
        }


    }
}
