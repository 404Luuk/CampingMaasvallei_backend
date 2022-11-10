using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampingMaasvalleiv2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampingSpot",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<float>(type: "real", nullable: false),
                    width = table.Column<float>(type: "real", nullable: false),
                    area = table.Column<float>(type: "real", nullable: false),
                    booked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampingSpot", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false),
                    campingspotid = table.Column<string>(name: "camping_spot_id", type: "nvarchar(max)", nullable: false),
                    guestcount = table.Column<int>(name: "guest_count", type: "int", nullable: false),
                    startdate = table.Column<DateTime>(name: "start_date", type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(name: "end_date", type: "datetime2", nullable: false),
                    accescode = table.Column<int>(name: "acces_code", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstname = table.Column<string>(name: "first_name", type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalcode = table.Column<string>(name: "postal_code", type: "nvarchar(max)", nullable: false),
                    dateofbirth = table.Column<string>(name: "date_of_birth", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampingSpot");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
