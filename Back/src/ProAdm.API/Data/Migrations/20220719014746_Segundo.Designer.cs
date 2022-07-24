﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAdm.API.Data;

namespace ProAdm.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220719014746_Segundo")]
    partial class Segundo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ProAdm.API.Models.Abastecimento", b =>
                {
                    b.Property<int>("AbastecimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Convenio")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("KmViatura")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Litros")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Responsavel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Saldo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Valor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Viatura")
                        .HasColumnType("INTEGER");

                    b.HasKey("AbastecimentoId");

                    b.ToTable("Abastecimentos");
                });

            modelBuilder.Entity("ProAdm.API.Models.Policial", b =>
                {
                    b.Property<int>("PolicialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostoGraduacao")
                        .HasColumnType("TEXT");

                    b.HasKey("PolicialId");

                    b.ToTable("Policiais");
                });

            modelBuilder.Entity("ProAdm.API.Models.Viatura", b =>
                {
                    b.Property<int>("ViaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Combustivel")
                        .HasColumnType("TEXT");

                    b.Property<int>("Odometro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prefixo")
                        .HasColumnType("TEXT");

                    b.HasKey("ViaturaId");

                    b.ToTable("Viaturas");
                });
#pragma warning restore 612, 618
        }
    }
}
