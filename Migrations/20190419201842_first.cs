using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace belt_exam.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Useres",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Useres", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlanId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Duration = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlanId);
                    table.ForeignKey(
                        name: "FK_Planes_Useres_UserId",
                        column: x => x.UserId,
                        principalTable: "Useres",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resevationes",
                columns: table => new
                {
                    ResevationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlanId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resevationes", x => x.ResevationId);
                    table.ForeignKey(
                        name: "FK_Resevationes_Planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Planes",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resevationes_Useres_UserId",
                        column: x => x.UserId,
                        principalTable: "Useres",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planes_UserId",
                table: "Planes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Resevationes_PlanId",
                table: "Resevationes",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Resevationes_UserId",
                table: "Resevationes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resevationes");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Useres");
        }
    }
}
