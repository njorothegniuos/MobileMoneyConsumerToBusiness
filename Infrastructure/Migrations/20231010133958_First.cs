using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumerToBusiness",
                columns: table => new
                {
                    ConsumerToBusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TransID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TransTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessShortCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillRefNumber = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgAccountBalance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPartyTransID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MSISDN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerToBusiness", x => x.ConsumerToBusinessId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumerToBusiness");
        }
    }
}
