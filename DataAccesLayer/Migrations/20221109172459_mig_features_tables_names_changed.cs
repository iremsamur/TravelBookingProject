using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class mig_features_tables_names_changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                table: "Features");

            migrationBuilder.RenameTable(
                name: "Features",
                newName: "Feature");

            migrationBuilder.RenameColumn(
                name: "Post1Name",
                table: "Feature",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Post1Image",
                table: "Feature",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Post1Description",
                table: "Feature",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "FeatureID",
                table: "Feature",
                newName: "SubFeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature",
                table: "Feature",
                column: "SubFeatureID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature",
                table: "Feature");

            migrationBuilder.RenameTable(
                name: "Feature",
                newName: "Features");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Features",
                newName: "Post1Name");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Features",
                newName: "Post1Image");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Features",
                newName: "Post1Description");

            migrationBuilder.RenameColumn(
                name: "SubFeatureID",
                table: "Features",
                newName: "FeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                table: "Features",
                column: "FeatureID");

            migrationBuilder.CreateTable(
                name: "SubFeatures",
                columns: table => new
                {
                    SubFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubFeatures", x => x.SubFeatureID);
                });
        }
    }
}
