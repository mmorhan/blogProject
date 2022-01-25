using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccessLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AboutDetail1 = table.Column<string>(type: "text", nullable: true),
                    AboutDetail2 = table.Column<string>(type: "text", nullable: true),
                    AboutImage1 = table.Column<string>(type: "text", nullable: true),
                    AboutImage2 = table.Column<string>(type: "text", nullable: true),
                    AboutMapLocation = table.Column<string>(type: "text", nullable: true),
                    AboutStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlogTitle = table.Column<string>(type: "text", nullable: true),
                    BlogContent = table.Column<string>(type: "text", nullable: true),
                    BlogThumbnailImage = table.Column<string>(type: "text", nullable: true),
                    BlogImage = table.Column<string>(type: "text", nullable: true),
                    BlogCreateDate = table.Column<string>(type: "text", nullable: true),
                    BlogStatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: true),
                    CategoryDescription = table.Column<string>(type: "text", nullable: true),
                    CategoryStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CommentUserName = table.Column<string>(type: "text", nullable: true),
                    CommentTitle = table.Column<string>(type: "text", nullable: true),
                    CommentContent = table.Column<string>(type: "text", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CommentStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactUserName = table.Column<string>(type: "text", nullable: true),
                    ContactMail = table.Column<string>(type: "text", nullable: true),
                    ContactSubject = table.Column<string>(type: "text", nullable: true),
                    ContactMessage = table.Column<string>(type: "text", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ContactStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WriterName = table.Column<string>(type: "text", nullable: true),
                    WriterAbout = table.Column<string>(type: "text", nullable: true),
                    WriterImage = table.Column<string>(type: "text", nullable: true),
                    WriterMail = table.Column<string>(type: "text", nullable: true),
                    WriterPassword = table.Column<string>(type: "text", nullable: true),
                    WriterStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
