using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixAirportRelationshipsInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagas_Registreerimine_RegistreerimineId",
                table: "Pagas");

            migrationBuilder.DropIndex(
                name: "IX_Pagas_RegistreerimineId",
                table: "Pagas");

            migrationBuilder.DropColumn(
                name: "RegistreerimineId",
                table: "Pagas");

            migrationBuilder.DropColumn(
                name: "VaravaId",
                table: "Lend");

            migrationBuilder.AlterColumn<string>(
                name: "Kaal",
                table: "Pagas",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Pagas_RegistreerimiseId",
                table: "Pagas",
                column: "RegistreerimiseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagas_Registreerimine_RegistreerimiseId",
                table: "Pagas",
                column: "RegistreerimiseId",
                principalTable: "Registreerimine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagas_Registreerimine_RegistreerimiseId",
                table: "Pagas");

            migrationBuilder.DropIndex(
                name: "IX_Pagas_RegistreerimiseId",
                table: "Pagas");

            migrationBuilder.AlterColumn<string>(
                name: "Kaal",
                table: "Pagas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<int>(
                name: "RegistreerimineId",
                table: "Pagas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VaravaId",
                table: "Lend",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagas_RegistreerimineId",
                table: "Pagas",
                column: "RegistreerimineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagas_Registreerimine_RegistreerimineId",
                table: "Pagas",
                column: "RegistreerimineId",
                principalTable: "Registreerimine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
