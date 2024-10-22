using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SampleEmployeeManagementSystem.DataAccess.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DateOfBirth", "Departement", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, -36, new DateTime(1988, 5, 25, 20, 54, 3, 203, DateTimeKind.Local).AddTicks(8109), "Engineering", "Alan Kreiger", "(784) 603-5805" },
                    { 2, -46, new DateTime(1978, 12, 13, 7, 59, 23, 889, DateTimeKind.Local).AddTicks(3028), "Training and development", "Peggy Rohan", "1-281-800-2316 x67983" },
                    { 3, -53, new DateTime(1971, 4, 28, 14, 17, 6, 941, DateTimeKind.Local).AddTicks(3130), "Finance", "Carole West", "703.988.0652 x00290" },
                    { 4, -67, new DateTime(1957, 8, 26, 6, 24, 45, 483, DateTimeKind.Local).AddTicks(2487), "Sales", "Jacob Conroy", "1-751-703-1331 x801" },
                    { 5, -23, new DateTime(2001, 6, 5, 12, 45, 8, 8, DateTimeKind.Local).AddTicks(2521), "Sales", "Irving Leffler", "(967) 246-5663" },
                    { 6, -69, new DateTime(1955, 1, 25, 12, 33, 42, 56, DateTimeKind.Local).AddTicks(4397), "Information Technology (IT)", "Edith Marks", "793-257-9183 x05447" },
                    { 7, -52, new DateTime(1972, 9, 22, 0, 45, 51, 621, DateTimeKind.Local).AddTicks(5454), "Training and development", "Heather Sanford", "985-517-9124" },
                    { 8, -52, new DateTime(1972, 4, 27, 20, 16, 58, 251, DateTimeKind.Local).AddTicks(4515), "Training and development", "Melvin Rutherford", "1-237-937-3326 x00717" },
                    { 9, -25, new DateTime(1999, 12, 23, 0, 43, 16, 746, DateTimeKind.Local).AddTicks(1201), "Training and development", "Karla Koepp", "943-209-1906 x8358" },
                    { 10, -40, new DateTime(1984, 1, 27, 20, 49, 18, 51, DateTimeKind.Local).AddTicks(8801), "Administration", "Bridget Goyette", "914.506.6387" },
                    { 11, -46, new DateTime(1978, 7, 28, 16, 36, 27, 850, DateTimeKind.Local).AddTicks(9740), "Information Technology (IT)", "Denise Jones", "1-444-404-8768" },
                    { 12, -54, new DateTime(1970, 3, 15, 12, 20, 40, 857, DateTimeKind.Local).AddTicks(3781), "Engineering", "Rodney Heller", "679-865-2608" },
                    { 13, -28, new DateTime(1996, 4, 13, 14, 52, 17, 128, DateTimeKind.Local).AddTicks(5085), "Engineering", "Nora Legros", "1-678-672-8408" },
                    { 14, -36, new DateTime(1988, 1, 11, 5, 55, 5, 824, DateTimeKind.Local).AddTicks(3459), "Training and development", "Julia Bogisich", "206.436.1099 x58168" },
                    { 15, -61, new DateTime(1963, 12, 29, 16, 30, 6, 290, DateTimeKind.Local).AddTicks(7960), "Training and development", "Sandy Wintheiser", "1-334-615-7143" },
                    { 16, -61, new DateTime(1963, 11, 7, 18, 36, 32, 615, DateTimeKind.Local).AddTicks(9790), "Customer support", "Stella O'Kon", "1-452-280-5863 x1400" },
                    { 17, -53, new DateTime(1971, 1, 17, 1, 25, 29, 759, DateTimeKind.Local).AddTicks(7119), "Training and development", "Ora Douglas", "(797) 500-8448 x22311" },
                    { 18, -51, new DateTime(1973, 6, 27, 13, 6, 0, 577, DateTimeKind.Local).AddTicks(6824), "Administration", "Kent Rippin", "1-537-579-2052 x6038" },
                    { 19, -49, new DateTime(1975, 12, 27, 7, 41, 23, 653, DateTimeKind.Local).AddTicks(3921), "Customer support", "Wesley Gutkowski", "280-310-5496" },
                    { 20, -29, new DateTime(1995, 9, 2, 13, 40, 38, 185, DateTimeKind.Local).AddTicks(6433), "Customer support", "Henrietta Barton", "897-584-4832 x1124" },
                    { 21, -52, new DateTime(1972, 6, 16, 1, 40, 34, 787, DateTimeKind.Local).AddTicks(4250), "Finance", "Darryl Miller", "507-263-2233" },
                    { 22, -45, new DateTime(1979, 12, 6, 7, 43, 43, 330, DateTimeKind.Local).AddTicks(7788), "Business Development", "Joshua Fahey", "234-211-1499 x5409" },
                    { 23, -24, new DateTime(2000, 12, 24, 6, 20, 51, 950, DateTimeKind.Local).AddTicks(7276), "Quality Assurance (QA)", "Leticia Lockman", "1-528-792-5372" },
                    { 24, -69, new DateTime(1955, 7, 26, 17, 51, 28, 292, DateTimeKind.Local).AddTicks(8291), "Finance", "Bruce Raynor", "942-606-1929" },
                    { 25, -51, new DateTime(1973, 11, 5, 15, 50, 32, 992, DateTimeKind.Local).AddTicks(4748), "Information Technology (IT)", "Miguel Dare", "(512) 986-9988 x5569" },
                    { 26, -24, new DateTime(2000, 4, 3, 17, 45, 57, 838, DateTimeKind.Local).AddTicks(6767), "Business Development", "Sonya Purdy", "841.345.0998" },
                    { 27, -65, new DateTime(1959, 11, 15, 11, 6, 41, 950, DateTimeKind.Local).AddTicks(2563), "Administration", "Alexander Kuphal", "207-494-3235" },
                    { 28, -39, new DateTime(1985, 8, 26, 0, 27, 16, 728, DateTimeKind.Local).AddTicks(8429), "Information Technology (IT)", "Janice Barrows", "653-279-1648 x546" },
                    { 29, -23, new DateTime(2001, 4, 24, 21, 10, 8, 307, DateTimeKind.Local).AddTicks(8778), "Sales", "Blake Kertzmann", "1-257-550-6806" },
                    { 30, -28, new DateTime(1996, 2, 20, 10, 8, 48, 192, DateTimeKind.Local).AddTicks(8024), "Finance", "Josephine Price", "302.813.9296 x5054" },
                    { 31, -29, new DateTime(1995, 2, 2, 17, 35, 1, 697, DateTimeKind.Local).AddTicks(4965), "Administration", "Sheryl Boyer", "787.507.9076 x1112" },
                    { 32, -33, new DateTime(1991, 4, 16, 19, 40, 31, 83, DateTimeKind.Local).AddTicks(5544), "Sales", "Mack Effertz", "1-590-429-4881 x47620" },
                    { 33, -26, new DateTime(1998, 5, 17, 23, 55, 42, 730, DateTimeKind.Local).AddTicks(9702), "Information Technology (IT)", "Mae Breitenberg", "1-867-642-0420 x50626" },
                    { 34, -37, new DateTime(1987, 9, 1, 0, 23, 12, 650, DateTimeKind.Local).AddTicks(3571), "Sales", "Kurt Kozey", "1-433-905-5081 x0978" },
                    { 35, -27, new DateTime(1997, 6, 15, 3, 21, 24, 423, DateTimeKind.Local).AddTicks(5636), "Training and development", "Traci Lebsack", "318-207-9001 x40362" },
                    { 36, -53, new DateTime(1971, 6, 12, 1, 43, 21, 368, DateTimeKind.Local).AddTicks(6119), "Training and development", "Kristine Cartwright", "408.735.4088 x6887" },
                    { 37, -37, new DateTime(1987, 6, 21, 21, 36, 6, 345, DateTimeKind.Local).AddTicks(891), "Administration", "Wilma Herzog", "1-261-352-3565 x740" },
                    { 38, -26, new DateTime(1998, 11, 18, 15, 16, 0, 307, DateTimeKind.Local).AddTicks(7450), "Customer support", "Maxine Little", "1-633-437-2441 x24163" },
                    { 39, -27, new DateTime(1997, 5, 6, 4, 3, 3, 184, DateTimeKind.Local).AddTicks(1430), "Information Technology (IT)", "Lonnie Heaney", "470.932.1982 x5160" },
                    { 40, -36, new DateTime(1988, 1, 9, 5, 16, 46, 85, DateTimeKind.Local).AddTicks(8282), "Finance", "Kirk Durgan", "(988) 791-3269 x77052" },
                    { 41, -47, new DateTime(1977, 8, 11, 20, 4, 37, 860, DateTimeKind.Local).AddTicks(3831), "Engineering", "Lawrence Spinka", "721-229-3147 x83955" },
                    { 42, -68, new DateTime(1956, 8, 15, 5, 40, 10, 18, DateTimeKind.Local).AddTicks(8323), "Sales", "Clay Renner", "(974) 496-1472" },
                    { 43, -60, new DateTime(1964, 8, 26, 22, 28, 13, 897, DateTimeKind.Local).AddTicks(5538), "Sales", "Marcos Balistreri", "(358) 777-1648" },
                    { 44, -64, new DateTime(1960, 4, 11, 0, 38, 55, 820, DateTimeKind.Local).AddTicks(6573), "Sales", "Emilio Pouros", "253.389.5981 x6265" },
                    { 45, -22, new DateTime(2002, 7, 11, 17, 7, 11, 726, DateTimeKind.Local).AddTicks(1635), "Engineering", "Tammy Hintz", "1-673-274-4650 x0950" },
                    { 46, -28, new DateTime(1996, 7, 19, 15, 45, 38, 889, DateTimeKind.Local).AddTicks(6192), "Administration", "Delbert O'Keefe", "(468) 743-1119 x78561" },
                    { 47, -67, new DateTime(1957, 9, 11, 2, 32, 52, 606, DateTimeKind.Local).AddTicks(7307), "Customer support", "Emmett Macejkovic", "367.679.3809 x90408" },
                    { 48, -56, new DateTime(1968, 7, 1, 7, 34, 38, 394, DateTimeKind.Local).AddTicks(8056), "Sales", "Oliver Jacobi", "415.901.6987 x0831" },
                    { 49, -49, new DateTime(1975, 4, 27, 1, 49, 27, 432, DateTimeKind.Local).AddTicks(2436), "Finance", "Jean Kunze", "510-597-1247 x56759" },
                    { 50, -67, new DateTime(1957, 12, 29, 15, 13, 17, 406, DateTimeKind.Local).AddTicks(1211), "Customer support", "Willie Williamson", "962.457.1157 x6790" },
                    { 51, -58, new DateTime(1966, 12, 22, 0, 17, 57, 954, DateTimeKind.Local).AddTicks(6300), "Administration", "Taylor Herman", "1-227-203-6596 x387" },
                    { 52, -21, new DateTime(2003, 11, 10, 23, 26, 21, 883, DateTimeKind.Local).AddTicks(9033), "Information Technology (IT)", "Ronnie Parisian", "249.527.0513 x516" },
                    { 53, -24, new DateTime(2000, 5, 2, 4, 48, 9, 49, DateTimeKind.Local).AddTicks(6762), "Customer support", "Miguel Dach", "1-255-203-5339 x25115" },
                    { 54, -29, new DateTime(1995, 8, 22, 1, 51, 39, 728, DateTimeKind.Local).AddTicks(9411), "Business Development", "Wendell Braun", "1-423-205-3281" },
                    { 55, -67, new DateTime(1957, 5, 1, 7, 0, 9, 832, DateTimeKind.Local).AddTicks(6124), "Training and development", "Wilfred MacGyver", "1-699-512-3830" },
                    { 56, -48, new DateTime(1976, 7, 17, 12, 47, 42, 261, DateTimeKind.Local).AddTicks(7564), "Information Technology (IT)", "Tabitha Abbott", "(980) 669-6522" },
                    { 57, -26, new DateTime(1998, 1, 8, 2, 13, 8, 774, DateTimeKind.Local).AddTicks(8370), "Customer support", "Myra Kuphal", "613-570-3520 x656" },
                    { 58, -62, new DateTime(1962, 2, 24, 14, 42, 35, 809, DateTimeKind.Local).AddTicks(3067), "Information Technology (IT)", "Kenny Aufderhar", "928-570-6009 x29966" },
                    { 59, -39, new DateTime(1985, 7, 7, 13, 36, 1, 809, DateTimeKind.Local).AddTicks(5486), "Information Technology (IT)", "Della Quigley", "1-281-494-5921 x939" },
                    { 60, -23, new DateTime(2001, 6, 11, 15, 53, 18, 30, DateTimeKind.Local).AddTicks(522), "Customer support", "Jeanette Strosin", "422-202-4193" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
