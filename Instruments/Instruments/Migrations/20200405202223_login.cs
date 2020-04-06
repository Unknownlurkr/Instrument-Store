using Microsoft.EntityFrameworkCore.Migrations;

namespace Instruments.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    RememberMe = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.UserName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Customer",
                table: "Customer",
                column: "Customer");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Login_Customer",
                table: "Customer",
                column: "Customer",
                principalTable: "Login",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Login_Customer",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Customer",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Customer");
        }
    }
}
