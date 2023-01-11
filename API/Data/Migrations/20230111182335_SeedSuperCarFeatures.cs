using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedSuperCarFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
     migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Air Bags')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Cup Holder')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Seat positioning')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('8D Sound')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('4-Wheel Steering')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Hybrid Mode')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('4-Wheel Active Suspension')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Apple CarPlay® and Android Auto™')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('A.I. Voice Assistant')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Pilot System')"); 
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Electronic Stability')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Parking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('360-degree camera')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Biometric door locks')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Fridge')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Personal AirConditioning')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Autonomous emergency braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Seat Massage Modes')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Cabin Air Purification')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Autonomous emergency braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Video Rearview Mirror')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Reverse Brake Assist')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('USB Charger')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Biometric Health Monitors')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Bluetooth')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Holographic Emitters')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Power Steering')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Multiple Drive Modes')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("delete * from Features')");
        }
    }
}
