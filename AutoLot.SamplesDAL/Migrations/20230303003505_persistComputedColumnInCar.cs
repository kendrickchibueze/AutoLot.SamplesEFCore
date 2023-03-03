using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.SamplesDAL.Migrations
{
    public partial class persistComputedColumnInCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Display",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                oldStored: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Display",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[PetName] + ' (' + [Color] + ')'",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[PetName] + ' (' + [Color] + ')'");
        }
    }
}
