using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_OneLove.Data.Migrations
{
    public partial class AddClothes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GuaranteeInMonth = table.Column<byte>(nullable: true),
                    Material = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Country = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    AmountInStock = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothes_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_BrandId",
                table: "Clothes",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
