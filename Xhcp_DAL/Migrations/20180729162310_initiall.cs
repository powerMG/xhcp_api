using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Xhcp_DAL.Migrations
{
    public partial class initiall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<DateTime>(nullable: false),
                    CreteTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CategoryImg = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    CategoryType = table.Column<int>(nullable: false),
                    CategoryPid = table.Column<int>(nullable: false),
                    CategoryUrl = table.Column<string>(nullable: true),
                    CategoryDoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<DateTime>(nullable: false),
                    CreteTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    FoodImg = table.Column<string>(nullable: false),
                    FoodTitle = table.Column<string>(nullable: false),
                    FoodNotice = table.Column<string>(nullable: true),
                    FoodDoc = table.Column<string>(nullable: false),
                    FoodAuthor = table.Column<string>(nullable: false),
                    FoodEffect = table.Column<string>(nullable: false),
                    FoodIngredientId = table.Column<string>(nullable: false),
                    FoodPracticeId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodIngredient",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<DateTime>(nullable: false),
                    CreteTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    IngredientName = table.Column<string>(nullable: false),
                    IngredientDosage = table.Column<string>(nullable: false),
                    IngredientTagId = table.Column<int>(nullable: false),
                    IngredientType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodIngredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodPractice",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<DateTime>(nullable: false),
                    CreteTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PracticeImg = table.Column<string>(nullable: false),
                    PracticeName = table.Column<string>(nullable: false),
                    PracticeDoc = table.Column<string>(nullable: true),
                    PracticeNum = table.Column<string>(nullable: false),
                    PracticeType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPractice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Userinfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<DateTime>(nullable: false),
                    CreteTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userinfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategory");

            migrationBuilder.DropTable(
                name: "FoodInfo");

            migrationBuilder.DropTable(
                name: "FoodIngredient");

            migrationBuilder.DropTable(
                name: "FoodPractice");

            migrationBuilder.DropTable(
                name: "Userinfo");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Courses");
        }
    }
}
