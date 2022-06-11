using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_BackEnd_Eterna.Migrations
{
    public partial class addStatiscModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    MainText = table.Column<string>(nullable: true),
                    AnotherText = table.Column<string>(nullable: true),
                    ProLan = table.Column<string>(nullable: true),
                    Percent = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");
        }
    }
}
