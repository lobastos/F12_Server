using System;
using LibsServer.Model;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace f12api.Migrations
{
    public partial class Inicio001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_cadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    ativo = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(nullable: false),
                    endereco = table.Column<Endereco>(type: "jsonb", nullable: true),
                    data_nascimento = table.Column<DateTime>(nullable: false),
                    tipo_pessoa = table.Column<int>(nullable: false),
                    observacoes = table.Column<string>(nullable: true),
                    numero_banco = table.Column<string>(nullable: true),
                    agencia = table.Column<string>(nullable: true),
                    conta = table.Column<string>(nullable: true),
                    cpf = table.Column<string>(maxLength: 11, nullable: false),
                    rg = table.Column<string>(nullable: true),
                    rg_local_expedicao = table.Column<string>(nullable: true),
                    rg_data_expedicao = table.Column<DateTime>(nullable: false),
                    inscricao_estadual = table.Column<string>(nullable: true),
                    inscricao_municipal = table.Column<string>(nullable: true),
                    escolaridade = table.Column<string>(nullable: true),
                    ocupacao = table.Column<string>(nullable: true),
                    pais_natal = table.Column<string>(nullable: true),
                    estado_natal = table.Column<string>(nullable: true),
                    cidade_natal = table.Column<string>(nullable: true),
                    nome_pai = table.Column<string>(nullable: true),
                    nome_mae = table.Column<string>(nullable: true),
                    estado_civil = table.Column<int>(nullable: false),
                    matricula = table.Column<string>(nullable: true),
                    ctps = table.Column<string>(nullable: true),
                    nis = table.Column<string>(nullable: true),
                    admissao = table.Column<Admissao>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_funcionarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_cadastro = table.Column<DateTime>(nullable: false),
                    data_atualizacao = table.Column<DateTime>(nullable: false),
                    ativo = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(nullable: false),
                    endereco = table.Column<Endereco>(type: "jsonb", nullable: true),
                    data_nascimento = table.Column<DateTime>(nullable: false),
                    tipo_pessoa = table.Column<int>(nullable: false),
                    observacoes = table.Column<string>(nullable: true),
                    numero_banco = table.Column<string>(nullable: true),
                    agencia = table.Column<string>(nullable: true),
                    conta = table.Column<string>(nullable: true),
                    login = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true),
                    funcionario_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "fk_usuarios_funcionarios_funcionario_id",
                        column: x => x.funcionario_id,
                        principalTable: "funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_usuarios_funcionario_id",
                table: "usuarios",
                column: "funcionario_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "funcionarios");
        }
    }
}
