using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisaProject.Migrations
{
    /// <inheritdoc />
    public partial class NewLastIsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_countries_CountryFromId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_countries_CountryliveInId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserValidation_Users_UserId",
                table: "UserValidation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserValidation_validation_ValidationId",
                table: "UserValidation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_validation",
                table: "validation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserValidation",
                table: "UserValidation");

            migrationBuilder.RenameTable(
                name: "validation",
                newName: "Validations");

            migrationBuilder.RenameTable(
                name: "UserValidation",
                newName: "userValidations");

            migrationBuilder.RenameIndex(
                name: "IX_UserValidation_ValidationId",
                table: "userValidations",
                newName: "IX_userValidations_ValidationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Validations",
                table: "Validations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userValidations",
                table: "userValidations",
                columns: new[] { "UserId", "ValidationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_countries_CountryFromId",
                table: "Users",
                column: "CountryFromId",
                principalTable: "countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_countries_CountryliveInId",
                table: "Users",
                column: "CountryliveInId",
                principalTable: "countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userValidations_Users_UserId",
                table: "userValidations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userValidations_Validations_ValidationId",
                table: "userValidations",
                column: "ValidationId",
                principalTable: "Validations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_countries_CountryFromId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_countries_CountryliveInId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_userValidations_Users_UserId",
                table: "userValidations");

            migrationBuilder.DropForeignKey(
                name: "FK_userValidations_Validations_ValidationId",
                table: "userValidations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Validations",
                table: "Validations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userValidations",
                table: "userValidations");

            migrationBuilder.RenameTable(
                name: "Validations",
                newName: "validation");

            migrationBuilder.RenameTable(
                name: "userValidations",
                newName: "UserValidation");

            migrationBuilder.RenameIndex(
                name: "IX_userValidations_ValidationId",
                table: "UserValidation",
                newName: "IX_UserValidation_ValidationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_validation",
                table: "validation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserValidation",
                table: "UserValidation",
                columns: new[] { "UserId", "ValidationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_countries_CountryFromId",
                table: "Users",
                column: "CountryFromId",
                principalTable: "countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_countries_CountryliveInId",
                table: "Users",
                column: "CountryliveInId",
                principalTable: "countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserValidation_Users_UserId",
                table: "UserValidation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserValidation_validation_ValidationId",
                table: "UserValidation",
                column: "ValidationId",
                principalTable: "validation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
