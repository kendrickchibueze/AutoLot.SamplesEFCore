using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.SamplesDAL.Migrations
{
    public partial class AddedDefaultvalueTocarByFluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory");
        }
    }
}
