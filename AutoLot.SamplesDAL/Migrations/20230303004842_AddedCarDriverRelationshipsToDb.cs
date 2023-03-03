﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.SamplesDAL.Migrations
{
    public partial class AddedCarDriverRelationshipsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryToDrivers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryToDrivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryToDrivers_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalSchema: "dbo",
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryToDrivers_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalSchema: "dbo",
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryToDrivers_DriverId",
                schema: "dbo",
                table: "InventoryToDrivers",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryToDrivers_InventoryId",
                schema: "dbo",
                table: "InventoryToDrivers",
                column: "InventoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryToDrivers",
                schema: "dbo");
        }
    }
}
