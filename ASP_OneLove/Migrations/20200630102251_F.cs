using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_OneLove.Migrations
{
    public partial class F : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialFacilities",
                table: "SpecialFacilities");

            migrationBuilder.DropColumn(
                name: "FacilityId",
                table: "SpecialFacilities");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SpecialFacilities",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialFacilities",
                table: "SpecialFacilities",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialFacilities",
                table: "SpecialFacilities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SpecialFacilities");

            migrationBuilder.AddColumn<int>(
                name: "FacilityId",
                table: "SpecialFacilities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialFacilities",
                table: "SpecialFacilities",
                column: "FacilityId");
        }
    }
}
