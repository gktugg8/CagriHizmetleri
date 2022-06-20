using Microsoft.EntityFrameworkCore.Migrations;

namespace CagriHizmetleri.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SorunID",
                table: "CagriOperatorleris",
                newName: "MusteriID");

            migrationBuilder.AddColumn<int>(
                name: "cagriID",
                table: "Musterilers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musterilers_cagriID",
                table: "Musterilers",
                column: "cagriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Musterilers_CagriOperatorleris_cagriID",
                table: "Musterilers",
                column: "cagriID",
                principalTable: "CagriOperatorleris",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musterilers_CagriOperatorleris_cagriID",
                table: "Musterilers");

            migrationBuilder.DropIndex(
                name: "IX_Musterilers_cagriID",
                table: "Musterilers");

            migrationBuilder.DropColumn(
                name: "cagriID",
                table: "Musterilers");

            migrationBuilder.RenameColumn(
                name: "MusteriID",
                table: "CagriOperatorleris",
                newName: "SorunID");
        }
    }
}
