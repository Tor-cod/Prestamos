using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Prestamos.Backend.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipoper = table.Column<int>(type: "integer", nullable: false),
                    PrimerNombre = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    SegundoNombre = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ApPaterno = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ApMaterno = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    RazonSocial = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    TipoSociedad = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    rfc = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    curp = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: true),
                    genero = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Accionista",
                columns: table => new
                {
                    IdAccionista = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    PrimerNombre = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    SegundoNombre = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accionista", x => x.IdAccionista);
                    table.ForeignKey(
                        name: "FK_Accionista_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateTable(
                name: "DatoFiscals",
                columns: table => new
                {
                    IdDatoFiscal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    NombrNegocio = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    FechaAltaSAT = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaIniOps = table.Column<DateOnly>(type: "date", nullable: false),
                    SerieFiel = table.Column<string>(type: "text", nullable: false),
                    rfc = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    regimenfiscal = table.Column<string>(type: "text", nullable: true),
                    ActividadEco = table.Column<string>(type: "text", nullable: true),
                    DomicilioFiscal = table.Column<string>(type: "text", nullable: true),
                    Colonia = table.Column<string>(type: "text", nullable: true),
                    Municipio = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    pais = table.Column<string>(type: "text", nullable: true),
                    CodigoPostal = table.Column<string>(type: "text", nullable: true),
                    ActividadSAT = table.Column<string>(type: "text", nullable: true),
                    ActividadCNBV = table.Column<string>(type: "text", nullable: true),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatoFiscals", x => x.IdDatoFiscal);
                    table.ForeignKey(
                        name: "FK_DatoFiscals_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateTable(
                name: "DatoPersonals",
                columns: table => new
                {
                    IdDatoPersonal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    estadocivil = table.Column<string>(type: "text", nullable: true),
                    regimenconyugal = table.Column<string>(type: "text", nullable: true),
                    CasadoCon = table.Column<string>(type: "text", nullable: true),
                    Ocupacion = table.Column<string>(type: "text", nullable: true),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatoPersonals", x => x.IdDatoPersonal);
                    table.ForeignKey(
                        name: "FK_DatoPersonals_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateTable(
                name: "Domicilios",
                columns: table => new
                {
                    IdDomicilio = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    Direccion = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    NoExt = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    NoInt = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true),
                    Referencia = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true),
                    Colonia = table.Column<string>(type: "text", nullable: false),
                    Municipio = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    CodPostal = table.Column<string>(type: "text", nullable: false),
                    Nacionalidad = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilios", x => x.IdDomicilio);
                    table.ForeignKey(
                        name: "FK_Domicilios_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateTable(
                name: "RepresentanteLegals",
                columns: table => new
                {
                    IdRepresentanteLegal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    TipoRepresentante = table.Column<string>(type: "text", nullable: true),
                    PrimerNombre = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    SegundoNombre = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ApPaterno = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ApMaterno = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Cargo = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    IDActConst = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentanteLegals", x => x.IdRepresentanteLegal);
                    table.ForeignKey(
                        name: "FK_RepresentanteLegals_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accionista_PersonaIdPersona",
                table: "Accionista",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_DatoFiscals_PersonaIdPersona",
                table: "DatoFiscals",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_DatoPersonals_PersonaIdPersona",
                table: "DatoPersonals",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_PersonaIdPersona",
                table: "Domicilios",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_RepresentanteLegals_PersonaIdPersona",
                table: "RepresentanteLegals",
                column: "PersonaIdPersona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accionista");

            migrationBuilder.DropTable(
                name: "DatoFiscals");

            migrationBuilder.DropTable(
                name: "DatoPersonals");

            migrationBuilder.DropTable(
                name: "Domicilios");

            migrationBuilder.DropTable(
                name: "RepresentanteLegals");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
