﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using logismart_api.Context;

#nullable disable

namespace logismartapi.Migrations
{
    [DbContext(typeof(MagazzinoContext))]
    [Migration("20230213205306_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("logismart_api.Models.AreaMagazzino", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroContatto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AreeMagazzino");
                });

            modelBuilder.Entity("logismart_api.Models.AttrezzaturaDiLavoro", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AreaMagazzinoId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<long?>("MansioneId")
                        .HasColumnType("bigint");

                    b.Property<string>("NomeAttrezzatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OperatoreId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AreaMagazzinoId");

                    b.HasIndex("MansioneId");

                    b.HasIndex("OperatoreId");

                    b.ToTable("AttrezzatureDiLavoro");
                });

            modelBuilder.Entity("logismart_api.Models.Azienda", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CodiceUnivoco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroContatto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartitaIva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pec")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aziende");
                });

            modelBuilder.Entity("logismart_api.Models.Mansione", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AreaMagazzinoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DataFine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFinePrevisto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInizio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInizioPrevisto")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AreaMagazzinoId");

                    b.ToTable("Mansioni");
                });

            modelBuilder.Entity("logismart_api.Models.Operatore", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AziendaId")
                        .HasColumnType("bigint");

                    b.Property<string>("CodiceFiscale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodiceOperatore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDiNascita")
                        .HasColumnType("datetime2");

                    b.Property<string>("IndirizzoDiDomicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LuogoDiNascita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MansioneId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroContatto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sesso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AziendaId");

                    b.HasIndex("MansioneId");

                    b.ToTable("Operatori");
                });

            modelBuilder.Entity("logismart_api.Models.AttrezzaturaDiLavoro", b =>
                {
                    b.HasOne("logismart_api.Models.AreaMagazzino", "AreaMagazzino")
                        .WithMany()
                        .HasForeignKey("AreaMagazzinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("logismart_api.Models.Mansione", null)
                        .WithMany("Attrezzature")
                        .HasForeignKey("MansioneId");

                    b.HasOne("logismart_api.Models.Operatore", "Operatore")
                        .WithMany()
                        .HasForeignKey("OperatoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AreaMagazzino");

                    b.Navigation("Operatore");
                });

            modelBuilder.Entity("logismart_api.Models.Mansione", b =>
                {
                    b.HasOne("logismart_api.Models.AreaMagazzino", "AreaMagazzino")
                        .WithMany()
                        .HasForeignKey("AreaMagazzinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AreaMagazzino");
                });

            modelBuilder.Entity("logismart_api.Models.Operatore", b =>
                {
                    b.HasOne("logismart_api.Models.Azienda", "Azienda")
                        .WithMany()
                        .HasForeignKey("AziendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("logismart_api.Models.Mansione", null)
                        .WithMany("Operatori")
                        .HasForeignKey("MansioneId");

                    b.Navigation("Azienda");
                });

            modelBuilder.Entity("logismart_api.Models.Mansione", b =>
                {
                    b.Navigation("Attrezzature");

                    b.Navigation("Operatori");
                });
#pragma warning restore 612, 618
        }
    }
}
