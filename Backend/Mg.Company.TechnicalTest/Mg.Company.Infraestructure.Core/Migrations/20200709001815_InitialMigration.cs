using Microsoft.EntityFrameworkCore.Migrations;

namespace Mg.Company.Infraestructure.Core.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContractTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 30, nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<string>(maxLength: 15, nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    Surname = table.Column<string>(maxLength: 20, nullable: false),
                    SecondSurname = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    SalaryValue = table.Column<decimal>(nullable: false),
                    ContractTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_ContractTypes_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ContractTypes",
                columns: new[] { "Id", "Active", "Description" },
                values: new object[] { 1, true, "Salario Mensual" });

            migrationBuilder.InsertData(
                table: "ContractTypes",
                columns: new[] { "Id", "Active", "Description" },
                values: new object[] { 2, true, "Salario Por Hora" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Active", "ContractTypeId", "Document", "FirstName", "SalaryValue", "SecondSurname", "Surname" },
                values: new object[,]
                {
                    { 1, true, 1, "12345688", "Yesion", 1250000m, "Acevedo", "Rojo" },
                    { 2, true, 1, "89384937", "Jesus", 1050000m, "Suarez", "Estiven" },
                    { 3, true, 1, "32489703", "Maria", 1000000m, "Hernandez", "Lopera" },
                    { 4, true, 1, "20930323", "Daniel", 978500m, "Acevedo", "Alvarez" },
                    { 5, true, 1, "102930293", "Gabriel", 2325000m, "Villa", "Alvarez" },
                    { 6, true, 2, "192839748", "Maria", 18720m, "Agudelo", "Fernanda" },
                    { 7, true, 2, "28309282", "Carlos", 20000m, "Granada", "Villa" },
                    { 8, true, 2, "73829320", "Angela", 12500m, "Rivera", "Pelaez" },
                    { 9, true, 2, "128982287", "Mateo", 9876m, "Henao", "Henao" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ContractTypeId",
                table: "Employees",
                column: "ContractTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ContractTypes");
        }
    }
}
