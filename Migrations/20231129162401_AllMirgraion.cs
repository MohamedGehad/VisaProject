using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisaProject.Migrations
{
    /// <inheritdoc />
    public partial class AllMirgraion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countOfDay = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countryDayCosts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cost = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countryDayCosts", x => x.id);
                    table.ForeignKey(
                        name: "FK_countryDayCosts_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_countryDayCosts_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expirePassportNumber = table.Column<DateTime>(type: "datetime2", nullable: false),
                    profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purposeOfTravel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    travelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryFromId = table.Column<int>(type: "int", nullable: false),
                    CountryliveInId = table.Column<int>(type: "int", nullable: false),
                    countryDayCostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_countries_CountryFromId",
                        column: x => x.CountryFromId,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_countries_CountryliveInId",
                        column: x => x.CountryliveInId,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_countryDayCosts_countryDayCostId",
                        column: x => x.countryDayCostId,
                        principalTable: "countryDayCosts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Passport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photograph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.id);
                    table.ForeignKey(
                        name: "FK_Images_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Armina",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marriageVoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hrLetter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armina", x => x.id);
                    table.ForeignKey(
                        name: "FK_Armina_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bahrain",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankStatement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bahrain", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bahrain_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turky",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchengenVisa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turky", x => x.id);
                    table.ForeignKey(
                        name: "FK_Turky_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armina_ImageId",
                table: "Armina",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Bahrain_ImageId",
                table: "Bahrain",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_countryDayCosts_CountryId",
                table: "countryDayCosts",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_countryDayCosts_DayId",
                table: "countryDayCosts",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_userId",
                table: "Images",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Turky_ImageId",
                table: "Turky",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_countryDayCostId",
                table: "Users",
                column: "countryDayCostId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryFromId",
                table: "Users",
                column: "CountryFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryliveInId",
                table: "Users",
                column: "CountryliveInId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armina");

            migrationBuilder.DropTable(
                name: "Bahrain");

            migrationBuilder.DropTable(
                name: "Turky");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "countryDayCosts");

            migrationBuilder.DropTable(
                name: "Days");
        }
    }
}
