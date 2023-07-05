using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Management.Migrations
{
    /// <inheritdoc />
    public partial class studentleadstodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentLeads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnquiryOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    StudentPhone = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    StudentEmail = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    LeadStatus = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NextFollowUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstituteId = table.Column<int>(type: "int", nullable: false),
                    CourseOfInterest = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    InterestLevel = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EnquiryType = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EnrollmentStatus = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentLeads_Institutes_InstituteId",
                        column: x => x.InstituteId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentLeads_InstituteId",
                table: "StudentLeads",
                column: "InstituteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentLeads");
        }
    }
}
