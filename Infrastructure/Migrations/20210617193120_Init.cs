using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Project_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Project_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Project_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Second_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Issue_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    User_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Project_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Project_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Issue_id);
                    table.ForeignKey(
                        name: "FK_Issues_Projects_Project_id1",
                        column: x => x.Project_id1,
                        principalTable: "Projects",
                        principalColumn: "Project_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Issues_Users_User_id1",
                        column: x => x.User_id1,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Comment_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_id1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    User_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Post_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Issue_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Comment_id);
                    table.ForeignKey(
                        name: "FK_Comments_Issues_Issue_id",
                        column: x => x.Issue_id,
                        principalTable: "Issues",
                        principalColumn: "Issue_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_User_id1",
                        column: x => x.User_id1,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Issue_id",
                table: "Comments",
                column: "Issue_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_User_id1",
                table: "Comments",
                column: "User_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_Project_id1",
                table: "Issues",
                column: "Project_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_User_id1",
                table: "Issues",
                column: "User_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
