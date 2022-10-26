using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlinesApp.Migrations
{
    public partial class initialmigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    flightNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fare = table.Column<double>(type: "float", nullable: false),
                    TotalSeat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.flightNo);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookTicket",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flightNo = table.Column<int>(type: "int", nullable: false),
                    PassengerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTicket", x => x.PassengerId);
                    table.ForeignKey(
                        name: "FK_BookTicket_Airlines_flightNo",
                        column: x => x.flightNo,
                        principalTable: "Airlines",
                        principalColumn: "flightNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "flightNo", "Destination", "Fare", "Source", "TotalSeat" },
                values: new object[,]
                {
                    { 101, "Destination1", 100.0, "Source1", 108 },
                    { 102, "Destination2", 100.0, "Source2", 108 },
                    { 103, "Destination3", 100.0, "Source3", 108 }
                });

            migrationBuilder.InsertData(
                table: "CustomerCare",
                columns: new[] { "Id", "Email", "PhoneNumber" },
                values: new object[] { 1, "myselfprageeth@gmail.com", 9746689742L });

            migrationBuilder.InsertData(
                table: "BookTicket",
                columns: new[] { "PassengerId", "Age", "City", "PassengerFirstName", "PassengerLastName", "flightNo" },
                values: new object[] { 1, 27, "Thalassery", "Prageeth", "Rajan", 101 });

            migrationBuilder.CreateIndex(
                name: "IX_BookTicket_flightNo",
                table: "BookTicket",
                column: "flightNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTicket");

            migrationBuilder.DropTable(
                name: "CustomerCare");

            migrationBuilder.DropTable(
                name: "Airlines");
        }
    }
}
