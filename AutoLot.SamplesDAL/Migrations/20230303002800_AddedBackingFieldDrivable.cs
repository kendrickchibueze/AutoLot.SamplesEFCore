using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.SamplesDAL.Migrations
{
    public partial class AddedBackingFieldDrivable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);
        }
    }
}
