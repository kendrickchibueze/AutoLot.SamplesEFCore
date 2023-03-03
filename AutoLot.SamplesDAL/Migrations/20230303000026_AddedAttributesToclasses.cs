using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.SamplesDAL.Migrations
{
    public partial class AddedAttributesToclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDriver_Driver_DriversId",
                table: "CarDriver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.RenameTable(
                name: "Makes",
                newName: "Makes",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "CarDriver",
                newName: "CarDriver",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Driver",
                newName: "Drivers",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Makes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "Drivers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "Drivers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                schema: "dbo",
                table: "Drivers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDriver_Drivers_DriversId",
                schema: "dbo",
                table: "CarDriver",
                column: "DriversId",
                principalSchema: "dbo",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDriver_Drivers_DriversId",
                schema: "dbo",
                table: "CarDriver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                schema: "dbo",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Makes",
                schema: "dbo",
                newName: "Makes");

            migrationBuilder.RenameTable(
                name: "CarDriver",
                schema: "dbo",
                newName: "CarDriver");

            migrationBuilder.RenameTable(
                name: "Drivers",
                schema: "dbo",
                newName: "Driver");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDriver_Driver_DriversId",
                table: "CarDriver",
                column: "DriversId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
