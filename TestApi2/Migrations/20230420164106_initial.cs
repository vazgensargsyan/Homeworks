using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApi2.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VegaBrand",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VegaBrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VegaBran__3214EC2734112A8F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VegaCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VegaObject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VegaKitchen = table.Column<bool>(type: "bit", nullable: true),
                    VegaDevice = table.Column<bool>(type: "bit", nullable: true),
                    VegaFurniture = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VegaCate__3214EC27067F376F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VegaDiscount",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VegaPrice = table.Column<decimal>(type: "money", nullable: false),
                    VegaObjectID = table.Column<int>(type: "int", nullable: true),
                    VegaBrand = table.Column<int>(type: "int", nullable: true),
                    VegaDiscountSize = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__VegaDisco__VegaB__286302EC",
                        column: x => x.VegaBrand,
                        principalTable: "VegaBrand",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__VegaDisco__VegaO__276EDEB3",
                        column: x => x.VegaObjectID,
                        principalTable: "VegaCategory",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VegaDiscount_VegaBrand",
                table: "VegaDiscount",
                column: "VegaBrand");

            migrationBuilder.CreateIndex(
                name: "IX_VegaDiscount_VegaObjectID",
                table: "VegaDiscount",
                column: "VegaObjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VegaDiscount");

            migrationBuilder.DropTable(
                name: "VegaBrand");

            migrationBuilder.DropTable(
                name: "VegaCategory");
        }
    }
}
