using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemSchoolV1.Api.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KelasModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaKelas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JamBuka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JamTutup = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KelasModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KelasModels");
        }
    }
}
