using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuscaCnpjMvc.Migrations
{
    /// <inheritdoc />
    public partial class FixedShadowPropertiesBuscaCnpj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CnpjResponse",
                columns: table => new
                {
                    Cnpj = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UltimaAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Tipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Porte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fantasia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abertura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NaturezaJuridica = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Municipio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Uf = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Efr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Situacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataSituacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MotivoSituacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SituacaoEspecial = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataSituacaoEspecial = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CapitalSocial = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Simples_IsEmpty = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: true),
                    Simples_Optante = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Simples_DataOpcao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Simples_DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Simples_UltimaAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Simei_IsEmpty = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: true),
                    Simei_Optante = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Simei_DataOpcao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Simei_DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Simei_UltimaAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Billing_IsEmpty = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: true),
                    Billing_Optante = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Billing_Database = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnpjResponse", x => x.Cnpj);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AtividadePrincipal",
                columns: table => new
                {
                    Sequencial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cnpj = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadePrincipal", x => x.Sequencial);
                    table.ForeignKey(
                        name: "FK_AtividadePrincipal_CnpjResponse_Cnpj",
                        column: x => x.Cnpj,
                        principalTable: "CnpjResponse",
                        principalColumn: "Cnpj");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AtividadeSecundaria",
                columns: table => new
                {
                    Sequencial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cnpj = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadeSecundaria", x => x.Sequencial);
                    table.ForeignKey(
                        name: "FK_AtividadeSecundaria_CnpjResponse_Cnpj",
                        column: x => x.Cnpj,
                        principalTable: "CnpjResponse",
                        principalColumn: "Cnpj");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Qsa",
                columns: table => new
                {
                    Sequencial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Qual = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisOrigem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeRepLegal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QualRepLegal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cnpj = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Qualificacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RepresentanteLegal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qsa", x => x.Sequencial);
                    table.ForeignKey(
                        name: "FK_Qsa_CnpjResponse_Cnpj",
                        column: x => x.Cnpj,
                        principalTable: "CnpjResponse",
                        principalColumn: "Cnpj");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadePrincipal_Cnpj",
                table: "AtividadePrincipal",
                column: "Cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadeSecundaria_Cnpj",
                table: "AtividadeSecundaria",
                column: "Cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_Qsa_Cnpj",
                table: "Qsa",
                column: "Cnpj");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtividadePrincipal");

            migrationBuilder.DropTable(
                name: "AtividadeSecundaria");

            migrationBuilder.DropTable(
                name: "Qsa");

            migrationBuilder.DropTable(
                name: "CnpjResponse");
        }
    }
}
