using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FileId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "FileId", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, 1L, false, "Soğan Kuru Dökme Kg", 9.9000000000000004 },
                    { 2L, 2L, false, "Hatay Arsuz Limonu Kg", 17.949999999999999 },
                    { 3L, 3L, false, "Muz Yerli Kg", 51.899999999999999 },
                    { 4L, 4L, false, "Portakal Sıkma File Kg", 16.899999999999999 },
                    { 5L, 5L, false, "Maydonoz Adet", 15.949999999999999 },
                    { 6L, 6L, false, "Hıyar Badem Paket Kg", 44.950000000000003 },
                    { 7L, 7L, false, "Mandalina Murcot", 39.950000000000003 },
                    { 8L, 8L, false, "Domates Kokteyl Kg", 69.950000000000003 },
                    { 9L, 9L, false, "Elma Starking Kg", 34.899999999999999 },
                    { 10L, 10L, false, "Kabak Sakız Kg", 34.950000000000003 },
                    { 11L, 11L, false, "Domates Salkım Kg", 49.950000000000003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
