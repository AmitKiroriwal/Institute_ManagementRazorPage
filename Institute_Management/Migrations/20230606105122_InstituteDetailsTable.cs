using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Management.Migrations
{
    /// <inheritdoc />
    public partial class InstituteDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Institutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InstituteName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    FounderName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AfflifiationNumber = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    InstitutionShortCode = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AlternateEmail = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CentralInventory = table.Column<bool>(type: "bit", nullable: false),
                    NumOfCentralInventory = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    OfficeNumber = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    InstituteType = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    PackageType = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    BreadNumber = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    OfficeAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institutes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Institutes_UserId",
                table: "Institutes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Institutes");
        }
    }
}
