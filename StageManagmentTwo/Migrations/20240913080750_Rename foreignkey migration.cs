using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StageManagmentTwo.Migrations
{
    /// <inheritdoc />
    public partial class Renameforeignkeymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Performances_PerformancePerfomanceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PerformancePerfomanceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PerformancePerfomanceId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "ProgramStageId",
                table: "Tickets",
                newName: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PerformanceId",
                table: "Tickets",
                column: "PerformanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Performances_PerformanceId",
                table: "Tickets",
                column: "PerformanceId",
                principalTable: "Performances",
                principalColumn: "PerfomanceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Performances_PerformanceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PerformanceId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "PerformanceId",
                table: "Tickets",
                newName: "ProgramStageId");

            migrationBuilder.AddColumn<int>(
                name: "PerformancePerfomanceId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PerformancePerfomanceId",
                table: "Tickets",
                column: "PerformancePerfomanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Performances_PerformancePerfomanceId",
                table: "Tickets",
                column: "PerformancePerfomanceId",
                principalTable: "Performances",
                principalColumn: "PerfomanceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
