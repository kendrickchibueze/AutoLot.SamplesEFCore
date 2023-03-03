using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.SamplesDAL.Migrations
{
    public partial class AddedComputedColumnWithFluentApiInCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Display",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[PetName] + ' (' + [Color] + ')'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Display",
                schema: "dbo",
                table: "Inventory");
        }
    }
}
