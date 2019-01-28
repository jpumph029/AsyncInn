using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class @fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomID1",
                table: "HotelRooms",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Seattle", "Seattle", "1234567890" },
                    { 2, "123 Portland St", "Portland", "5415416667" },
                    { 3, "234 Springfield St", "Springfield", "0987654321" },
                    { 4, "345 Eugene St", "Eugene", "2347568888" },
                    { 5, "1234 Astoria wy", "Astoria", "2223334444" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[,]
                {
                    { 1, 0, "StudioFirstFloor" },
                    { 2, 0, "StudioSecondFloor" },
                    { 3, 1, "OneBedFirstFloor" },
                    { 4, 1, "OneBedSecondFloor" },
                    { 5, 2, "TwoBedFirstFloor" },
                    { 6, 2, "TwoBedSecondFloor" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms",
                column: "RoomID1",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Amenities");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "RoomID1",
                table: "HotelRooms",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms",
                column: "RoomID1",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
