using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class AirportInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LennuFirma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Riik = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LennuFirma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lennujaam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Riik = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Linn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lennujaam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lennuk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registreerimisnumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Mudel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsteKohtadeArv = table.Column<int>(type: "int", nullable: false),
                    ValmistamiseAasta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lennuk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reisija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sunniaeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DokumendiNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reisija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terminal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminaliNumber = table.Column<int>(type: "int", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Asukoht = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Töötaja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ametikoht = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TerminalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötaja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Töötaja_Terminal_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Varav",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaravaNumber = table.Column<int>(type: "int", nullable: false),
                    Asukoht = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaxLennukiSuurus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TerminalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varav", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Varav_Terminal_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lennunumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ValjumiseKuupaevJaAeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaabumiseKuupaevJaAeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LahteLennujaamId = table.Column<int>(type: "int", nullable: false),
                    SihtLennujaamId = table.Column<int>(type: "int", nullable: false),
                    LennuFirmaId = table.Column<int>(type: "int", nullable: false),
                    LennukId = table.Column<int>(type: "int", nullable: false),
                    VaravaId = table.Column<int>(type: "int", nullable: false),
                    VaravId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lend_LennuFirma_LennuFirmaId",
                        column: x => x.LennuFirmaId,
                        principalTable: "LennuFirma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lend_Lennujaam_LahteLennujaamId",
                        column: x => x.LahteLennujaamId,
                        principalTable: "Lennujaam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lend_Lennujaam_SihtLennujaamId",
                        column: x => x.SihtLennujaamId,
                        principalTable: "Lennujaam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lend_Lennuk_LennukId",
                        column: x => x.LennukId,
                        principalTable: "Lennuk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lend_Varav_VaravId",
                        column: x => x.VaravId,
                        principalTable: "Varav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LennuStaatuseAjalugu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LendId = table.Column<int>(type: "int", nullable: false),
                    Staatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MuutmiseAeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pohjus = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LennuStaatuseAjalugu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LennuStaatuseAjalugu_Lend_LendId",
                        column: x => x.LendId,
                        principalTable: "Lend",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registreerimine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReisijaId = table.Column<int>(type: "int", nullable: false),
                    LendId = table.Column<int>(type: "int", nullable: false),
                    IsteKohaNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RegistreerimiseAeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PiletiTuup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registreerimine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registreerimine_Lend_LendId",
                        column: x => x.LendId,
                        principalTable: "Lend",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registreerimine_Reisija_ReisijaId",
                        column: x => x.ReisijaId,
                        principalTable: "Reisija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagasilipikuNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kaal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PagasiTuup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegistreerimiseId = table.Column<int>(type: "int", nullable: false),
                    RegistreerimineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagas_Registreerimine_RegistreerimineId",
                        column: x => x.RegistreerimineId,
                        principalTable: "Registreerimine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lend_LahteLennujaamId",
                table: "Lend",
                column: "LahteLennujaamId");

            migrationBuilder.CreateIndex(
                name: "IX_Lend_LennuFirmaId",
                table: "Lend",
                column: "LennuFirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lend_LennukId",
                table: "Lend",
                column: "LennukId");

            migrationBuilder.CreateIndex(
                name: "IX_Lend_SihtLennujaamId",
                table: "Lend",
                column: "SihtLennujaamId");

            migrationBuilder.CreateIndex(
                name: "IX_Lend_VaravId",
                table: "Lend",
                column: "VaravId");

            migrationBuilder.CreateIndex(
                name: "IX_LennuStaatuseAjalugu_LendId",
                table: "LennuStaatuseAjalugu",
                column: "LendId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagas_RegistreerimineId",
                table: "Pagas",
                column: "RegistreerimineId");

            migrationBuilder.CreateIndex(
                name: "IX_Registreerimine_LendId",
                table: "Registreerimine",
                column: "LendId");

            migrationBuilder.CreateIndex(
                name: "IX_Registreerimine_ReisijaId",
                table: "Registreerimine",
                column: "ReisijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_TerminalId",
                table: "Töötaja",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Varav_TerminalId",
                table: "Varav",
                column: "TerminalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LennuStaatuseAjalugu");

            migrationBuilder.DropTable(
                name: "Pagas");

            migrationBuilder.DropTable(
                name: "Töötaja");

            migrationBuilder.DropTable(
                name: "Registreerimine");

            migrationBuilder.DropTable(
                name: "Lend");

            migrationBuilder.DropTable(
                name: "Reisija");

            migrationBuilder.DropTable(
                name: "LennuFirma");

            migrationBuilder.DropTable(
                name: "Lennujaam");

            migrationBuilder.DropTable(
                name: "Lennuk");

            migrationBuilder.DropTable(
                name: "Varav");

            migrationBuilder.DropTable(
                name: "Terminal");
        }
    }
}
