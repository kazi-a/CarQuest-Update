using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarQuest.Migrations
{
    public partial class AddCarInventoryToCustomerContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.CreateTable(
                name: "CarInventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarInventories_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarInventories",
                columns: new[] { "ID", "CustomerID", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 1, 1, "Toyota", "Camry", 2020 },
                    { 2, 2, "Honda", "Civic", 2021 }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "emma@stone.com", "Emma", "Stone" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "chris@evans.com", "Chris", "Evans" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "scarlett@johansson.com", "Scarlett", "Johansson" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "robert@downey.com", "Robert", "Downey Jr." });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "natalie@portman.com", "Natalie", "Portman" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "harrison@ford.com", "Harrison", "Ford" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "denzel@washington.com", "Denzel", "Washington" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "leonardo@dicaprio.com", "Leonardo", "DiCaprio" });

            migrationBuilder.CreateIndex(
                name: "IX_CarInventories_CustomerID",
                table: "CarInventories",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarInventories");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { null, "James", "Bond" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { null, "Tom", "Cruise" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { null, "Johnny", "Depp" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { null, "Leo", "Blade" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "emma@stone.com", "Emma", "Stone" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "chris@evans.com", "Chris", "Evans" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "scarlett@johansson.com", "Scarlett", "Johansson" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "robert@downey.com", "Robert", "Downey Jr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "Cell", "City", "Email", "FirstName", "GenderIdentity", "LastName", "State", "Zip" },
                values: new object[,]
                {
                    { 10, null, null, null, "natalie@portman.com", "Natalie", null, "Portman", null, null },
                    { 11, null, null, null, "harrison@ford.com", "Harrison", null, "Ford", null, null },
                    { 12, null, null, null, "denzel@washington.com", "Denzel", null, "Washington", null, null },
                    { 13, null, null, null, "leonardo@dicaprio.com", "Leonardo", null, "DiCaprio", null, null },
                    { 14, null, null, null, "angelina@jolie.com", "Angelina", null, "Jolie", null, null },
                    { 15, null, null, null, "brad@pitt.com", "Brad", null, "Pitt", null, null }
                });
        }
    }
}
