﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace senkron_todo_api.Migrations
{
    /// <inheritdoc />
    public partial class Addeddeletefields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Todos",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Todos",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Todos");
        }
    }
}
