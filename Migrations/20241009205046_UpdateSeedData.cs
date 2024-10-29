using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarQuest.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 3,
                column: "LastName",
                value: "Cruise");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "Address", "Cell", "City", "Email", "FirstName", "GenderIdentity", "LastName", "State", "Zip" },
                values: new object[,]
                {
                    { 6, null, null, null, "emma@stone.com", "Emma", null, "Stone", null, null },
                    { 7, null, null, null, "chris@evans.com", "Chris", null, "Evans", null, null },
                    { 8, null, null, null, "scarlett@johansson.com", "Scarlett", null, "Johansson", null, null },
                    { 9, null, null, null, "robert@downey.com", "Robert", null, "Downey Jr.", null, null },
                    { 10, null, null, null, "natalie@portman.com", "Natalie", null, "Portman", null, null },
                    { 11, null, null, null, "harrison@ford.com", "Harrison", null, "Ford", null, null },
                    { 12, null, null, null, "denzel@washington.com", "Denzel", null, "Washington", null, null },
                    { 13, null, null, null, "leonardo@dicaprio.com", "Leonardo", null, "DiCaprio", null, null },
                    { 14, null, null, null, "angelina@jolie.com", "Angelina", null, "Jolie", null, null },
                    { 15, null, null, null, "brad@pitt.com", "Brad", null, "Pitt", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 3,
                column: "LastName",
                value: "Cruse");
        }
    }
}
