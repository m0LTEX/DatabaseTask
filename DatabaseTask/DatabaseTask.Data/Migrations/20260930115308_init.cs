using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crime",
                columns: table => new
                {
                    CrimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Difficulty_level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crime", x => x.CrimeId);
                });

            migrationBuilder.CreateTable(
                name: "Prisons",
                columns: table => new
                {
                    PrisonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Maximum_capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisons", x => x.PrisonId);
                });

            migrationBuilder.CreateTable(
                name: "Punishment",
                columns: table => new
                {
                    PunishmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Punishment_Type = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punishment", x => x.PunishmentId);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personal_Number = table.Column<int>(type: "int", nullable: false),
                    Telephone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relation_To_Prisoner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorsId);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Block_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Security_level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Block_id);
                    table.ForeignKey(
                        name: "FK_Block_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prisons",
                        principalColumn: "PrisonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prison_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Building_Prisons_Prison_id",
                        column: x => x.Prison_id,
                        principalTable: "Prisons",
                        principalColumn: "PrisonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guards",
                columns: table => new
                {
                    GuardsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonId = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Worker_Number = table.Column<int>(type: "int", nullable: false),
                    job = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guards", x => x.GuardsId);
                    table.ForeignKey(
                        name: "FK_Guards_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prisons",
                        principalColumn: "PrisonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chamber",
                columns: table => new
                {
                    chamberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Maximum_capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamber", x => x.chamberId);
                    table.ForeignKey(
                        name: "FK_Chamber_Block_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Block",
                        principalColumn: "Block_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuardsId = table.Column<int>(type: "int", nullable: false),
                    Start_Time = table.Column<int>(type: "int", nullable: false),
                    Finish_Time = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.ShiftId);
                    table.ForeignKey(
                        name: "FK_Shift_Guards_GuardsId",
                        column: x => x.GuardsId,
                        principalTable: "Guards",
                        principalColumn: "GuardsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prisoners",
                columns: table => new
                {
                    PrisonerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChamberId = table.Column<int>(type: "int", nullable: false),
                    PunishmentId = table.Column<int>(type: "int", nullable: false),
                    CrimeId = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Personal_Number = table.Column<int>(type: "int", nullable: false),
                    Arrival_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prisoner_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisoners", x => x.PrisonerId);
                    table.ForeignKey(
                        name: "FK_Prisoners_Chamber_ChamberId",
                        column: x => x.ChamberId,
                        principalTable: "Chamber",
                        principalColumn: "chamberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prisoners_Crime_CrimeId",
                        column: x => x.CrimeId,
                        principalTable: "Crime",
                        principalColumn: "CrimeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prisoners_Punishment_PunishmentId",
                        column: x => x.PunishmentId,
                        principalTable: "Punishment",
                        principalColumn: "PunishmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuardsId = table.Column<int>(type: "int", nullable: false),
                    PrisonerId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start_Time = table.Column<int>(type: "int", nullable: false),
                    Finish_Time = table.Column<int>(type: "int", nullable: false),
                    Visiting_Status = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visit_Guards_GuardsId",
                        column: x => x.GuardsId,
                        principalTable: "Guards",
                        principalColumn: "GuardsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visit_Prisoners_PrisonerId",
                        column: x => x.PrisonerId,
                        principalTable: "Prisoners",
                        principalColumn: "PrisonerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Block_PrisonId",
                table: "Block",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_Prison_id",
                table: "Building",
                column: "Prison_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chamber_BlockId",
                table: "Chamber",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_PrisonId",
                table: "Guards",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_ChamberId",
                table: "Prisoners",
                column: "ChamberId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_CrimeId",
                table: "Prisoners",
                column: "CrimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_PunishmentId",
                table: "Prisoners",
                column: "PunishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_GuardsId",
                table: "Shift",
                column: "GuardsId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_GuardsId",
                table: "Visit",
                column: "GuardsId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PrisonerId",
                table: "Visit",
                column: "PrisonerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Guards");

            migrationBuilder.DropTable(
                name: "Prisoners");

            migrationBuilder.DropTable(
                name: "Chamber");

            migrationBuilder.DropTable(
                name: "Crime");

            migrationBuilder.DropTable(
                name: "Punishment");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Prisons");
        }
    }
}
