﻿// <auto-generated />
using System;
using LibsServer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using f12api.Database;

namespace f12api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200419015117_Inicio001")]
    partial class Inicio001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("LibsServer.Model.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<Admissao>("Admissao")
                        .HasColumnName("admissao")
                        .HasColumnType("jsonb");

                    b.Property<string>("Agencia")
                        .HasColumnName("agencia")
                        .HasColumnType("text");

                    b.Property<bool>("Ativo")
                        .HasColumnName("ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnName("cpf")
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.Property<string>("CTPS")
                        .HasColumnName("ctps")
                        .HasColumnType("text");

                    b.Property<string>("CidadeNatal")
                        .HasColumnName("cidade_natal")
                        .HasColumnType("text");

                    b.Property<string>("Conta")
                        .HasColumnName("conta")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnUpdate()
                        .HasColumnName("data_atualizacao")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("data_cadastro")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("data_nascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<Endereco>("Endereco")
                        .HasColumnName("endereco")
                        .HasColumnType("jsonb");

                    b.Property<string>("Escolaridade")
                        .HasColumnName("escolaridade")
                        .HasColumnType("text");

                    b.Property<int>("EstadoCivil")
                        .HasColumnName("estado_civil")
                        .HasColumnType("integer");

                    b.Property<string>("EstadoNatal")
                        .HasColumnName("estado_natal")
                        .HasColumnType("text");

                    b.Property<string>("InscricaoEstadual")
                        .HasColumnName("inscricao_estadual")
                        .HasColumnType("text");

                    b.Property<string>("InscricaoMunicipal")
                        .HasColumnName("inscricao_municipal")
                        .HasColumnType("text");

                    b.Property<string>("Matricula")
                        .HasColumnName("matricula")
                        .HasColumnType("text");

                    b.Property<string>("NIS")
                        .HasColumnName("nis")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("text");

                    b.Property<string>("NomeMae")
                        .HasColumnName("nome_mae")
                        .HasColumnType("text");

                    b.Property<string>("NomePai")
                        .HasColumnName("nome_pai")
                        .HasColumnType("text");

                    b.Property<string>("NumeroBanco")
                        .HasColumnName("numero_banco")
                        .HasColumnType("text");

                    b.Property<string>("Observacoes")
                        .HasColumnName("observacoes")
                        .HasColumnType("text");

                    b.Property<string>("Ocupacao")
                        .HasColumnName("ocupacao")
                        .HasColumnType("text");

                    b.Property<string>("PaisNatal")
                        .HasColumnName("pais_natal")
                        .HasColumnType("text");

                    b.Property<string>("RG")
                        .HasColumnName("rg")
                        .HasColumnType("text");

                    b.Property<DateTime>("RG_DataExpedicao")
                        .HasColumnName("rg_data_expedicao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RG_LocalExpedicao")
                        .HasColumnName("rg_local_expedicao")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnName("telefone")
                        .HasColumnType("text");

                    b.Property<int>("TipoPessoa")
                        .HasColumnName("tipo_pessoa")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("pk_funcionarios");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("LibsServer.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Agencia")
                        .HasColumnName("agencia")
                        .HasColumnType("text");

                    b.Property<bool>("Ativo")
                        .HasColumnName("ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Conta")
                        .HasColumnName("conta")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("data_atualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("data_cadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("data_nascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<Endereco>("Endereco")
                        .HasColumnName("endereco")
                        .HasColumnType("jsonb");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnName("funcionario_id")
                        .HasColumnType("integer");

                    b.Property<string>("Login")
                        .HasColumnName("login")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("text");

                    b.Property<string>("NumeroBanco")
                        .HasColumnName("numero_banco")
                        .HasColumnType("text");

                    b.Property<string>("Observacoes")
                        .HasColumnName("observacoes")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnName("senha")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnName("telefone")
                        .HasColumnType("text");

                    b.Property<int>("TipoPessoa")
                        .HasColumnName("tipo_pessoa")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("pk_usuarios");

                    b.HasIndex("FuncionarioId")
                        .HasName("ix_usuarios_funcionario_id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("LibsServer.Model.Usuario", b =>
                {
                    b.HasOne("LibsServer.Model.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .HasConstraintName("fk_usuarios_funcionarios_funcionario_id");
                });
#pragma warning restore 612, 618
        }
    }
}
