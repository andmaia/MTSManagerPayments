﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240208215026_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CredentialsId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CredentialsId");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("Domain.Entities.Credentials", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("EntranceValue")
                        .HasColumnType("float");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("PercentageDefault")
                        .HasColumnType("float");

                    b.Property<float>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMachine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CompanyId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("PaymentsMachines");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMachineForWorker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PaymentMachineId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WorkerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMachineId");

                    b.HasIndex("WorkerId");

                    b.ToTable("paymentMachineForWorkers");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMethod", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentMachineId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<float>("Tax")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMachineId");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("Domain.Entities.PaymentSummary", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Entrace")
                        .HasColumnType("float");

                    b.Property<bool>("EntraceAccount")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("PaidDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PaymentReceiptURL")
                        .HasColumnType("longtext");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<float>("RemaingValueToCompany")
                        .HasColumnType("float");

                    b.Property<float>("RemainingValueToArtist")
                        .HasColumnType("float");

                    b.Property<float>("TotalTaxToCompany")
                        .HasColumnType("float");

                    b.Property<float>("TotalTaxToWorker")
                        .HasColumnType("float");

                    b.Property<float>("TotalTaxs")
                        .HasColumnType("float");

                    b.Property<float>("TotalValue")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("ValueCompanyRecived")
                        .HasColumnType("float");

                    b.Property<float>("ValueToCompanyReciver")
                        .HasColumnType("float");

                    b.Property<float>("ValueToWorkerReciver")
                        .HasColumnType("float");

                    b.Property<float>("ValueWorkerRecived")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.ToTable("PaymentsSummary");
                });

            modelBuilder.Entity("Domain.Entities.PaymentUnity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("ArtistPercentage")
                        .HasColumnType("float");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PaymentMethodId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("PaymentMode")
                        .HasColumnType("int");

                    b.Property<float>("TotalTax")
                        .HasColumnType("float");

                    b.Property<float>("Value")
                        .HasColumnType("float");

                    b.Property<float>("ValueToArtist")
                        .HasColumnType("float");

                    b.Property<float>("ValueToCompany")
                        .HasColumnType("float");

                    b.Property<float>("ValueWithTax")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("PaymentUnities");
                });

            modelBuilder.Entity("Domain.Entities.Procedure", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WorkerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Procedures");
                });

            modelBuilder.Entity("Domain.Entities.Worker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Comission")
                        .HasColumnType("float");

                    b.Property<string>("CompanyId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CredentialsId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("FinishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CredentialsId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("Domain.Entities.Company", b =>
                {
                    b.HasOne("Domain.Entities.Credentials", "Credentials")
                        .WithMany()
                        .HasForeignKey("CredentialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Credentials");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMachine", b =>
                {
                    b.HasOne("Domain.Entities.Company", "Company")
                        .WithMany("PaymentMachines")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMachineForWorker", b =>
                {
                    b.HasOne("Domain.Entities.PaymentMachine", "PaymentMachine")
                        .WithMany("PaymentMachineForWorkers")
                        .HasForeignKey("PaymentMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Worker", "Worker")
                        .WithMany("paymentMachineForWorkers")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMachine");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMethod", b =>
                {
                    b.HasOne("Domain.Entities.PaymentMachine", "PaymentMachine")
                        .WithMany("PaymentsMethods")
                        .HasForeignKey("PaymentMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMachine");
                });

            modelBuilder.Entity("Domain.Entities.PaymentSummary", b =>
                {
                    b.HasOne("Domain.Entities.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Domain.Entities.PaymentUnity", b =>
                {
                    b.HasOne("Domain.Entities.Payment", "Payment")
                        .WithMany("PaymentUnities")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany("PaymentUnities")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("Domain.Entities.Procedure", b =>
                {
                    b.HasOne("Domain.Entities.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Worker", "Worker")
                        .WithMany("Procedures")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Domain.Entities.Worker", b =>
                {
                    b.HasOne("Domain.Entities.Company", "Company")
                        .WithMany("Workers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Credentials", "Credentials")
                        .WithMany()
                        .HasForeignKey("CredentialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Credentials");
                });

            modelBuilder.Entity("Domain.Entities.Company", b =>
                {
                    b.Navigation("PaymentMachines");

                    b.Navigation("Workers");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.Navigation("PaymentUnities");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMachine", b =>
                {
                    b.Navigation("PaymentMachineForWorkers");

                    b.Navigation("PaymentsMethods");
                });

            modelBuilder.Entity("Domain.Entities.PaymentMethod", b =>
                {
                    b.Navigation("PaymentUnities");
                });

            modelBuilder.Entity("Domain.Entities.Worker", b =>
                {
                    b.Navigation("Procedures");

                    b.Navigation("paymentMachineForWorkers");
                });
#pragma warning restore 612, 618
        }
    }
}
