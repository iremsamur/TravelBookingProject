using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class mig_create_destination_details_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationDetailID",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestinationDetailsDestinationDetailID",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DestinationDetailss",
                columns: table => new
                {
                    DestinationDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationDetailss", x => x.DestinationDetailID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_DestinationDetailsDestinationDetailID",
                table: "Destinations",
                column: "DestinationDetailsDestinationDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_DestinationDetailss_DestinationDetailsDestinationDetailID",
                table: "Destinations",
                column: "DestinationDetailsDestinationDetailID",
                principalTable: "DestinationDetailss",
                principalColumn: "DestinationDetailID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_DestinationDetailss_DestinationDetailsDestinationDetailID",
                table: "Destinations");

            migrationBuilder.DropTable(
                name: "DestinationDetailss");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_DestinationDetailsDestinationDetailID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationDetailID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationDetailsDestinationDetailID",
                table: "Destinations");
        }
    }
}
