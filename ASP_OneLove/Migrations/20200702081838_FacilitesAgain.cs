using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_OneLove.Migrations
{
    public partial class FacilitesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialFacilitiesAsString",
                table: "Apartment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialFacilitiesAsString",
                table: "Apartment");
        }
    }
}
