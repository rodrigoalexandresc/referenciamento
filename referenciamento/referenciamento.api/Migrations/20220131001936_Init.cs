using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace referenciamento.api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prontuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Numero = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    CPF = table.Column<string>(type: "text", nullable: true),
                    RG = table.Column<string>(type: "text", nullable: true),
                    NIS = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    DataRef = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TecRef = table.Column<string>(type: "text", nullable: true),
                    SituacaoCadastro = table.Column<int>(type: "integer", nullable: false),
                    AnoAtualizacaoSituacao = table.Column<int>(type: "integer", nullable: false),
                    ArquivoMorto = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProntuarioProgramaSocial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DomicilioId = table.Column<int>(type: "integer", nullable: false),
                    ProgramaSocial = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProntuarioProgramaSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProntuarioProgramaSocial_Prontuarios_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Prontuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProntuarioProgramaSocial_DomicilioId",
                table: "ProntuarioProgramaSocial",
                column: "DomicilioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProntuarioProgramaSocial");

            migrationBuilder.DropTable(
                name: "Prontuarios");
        }
    }
}
