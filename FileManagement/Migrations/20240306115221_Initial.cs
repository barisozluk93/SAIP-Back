using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FileManagement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ContentType = table.Column<string>(type: "text", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    Extension = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<decimal>(type: "numeric", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "ContentType", "Extension", "IsDeleted", "Length", "Name", "Path" },
                values: new object[,]
                {
                    { 1L, "image/jpg", ".jpg", false, 14086m, "1", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\1.jpg" },
                    { 2L, "image/jpg", ".jpg", false, 12481m, "2", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\2.jpg" },
                    { 3L, "image/jpg", ".jpg", false, 8663m, "3", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\3.jpg" },
                    { 4L, "image/jpg", ".jpg", false, 20976m, "4", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\4.jpg" },
                    { 5L, "image/jpg", ".jpg", false, 11770m, "5", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\5.jpg" },
                    { 6L, "image/jpg", ".jpg", false, 13585m, "6", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\6.jpg" },
                    { 7L, "image/jpg", ".jpg", false, 15732m, "7", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\7.jpg" },
                    { 8L, "image/jpg", ".jpg", false, 19896m, "8", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\8.jpg" },
                    { 9L, "image/jpg", ".jpg", false, 13939m, "9", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\9.jpg" },
                    { 10L, "image/jpg", ".jpg", false, 12552m, "10", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\10.jpg" },
                    { 11L, "image/jpg", ".jpg", false, 20349m, "11", "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\11.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
