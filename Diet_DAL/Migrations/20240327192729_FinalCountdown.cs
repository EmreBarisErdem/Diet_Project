using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Diet_DAL.Migrations
{
    /// <inheritdoc />
    public partial class FinalCountdown : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategoryName = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.FoodCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "FoodSales",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(50)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    UserStatus = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(20)", nullable: false),
                    Weight = table.Column<double>(type: "float", maxLength: 250, nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    ActivityStatus = table.Column<int>(type: "int", nullable: false),
                    CaloriesPerDay = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Calories = table.Column<int>(type: "integer", maxLength: 1000, nullable: false),
                    Quantity = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    PicturePath = table.Column<string>(type: "varchar(250)", nullable: true),
                    Grams = table.Column<int>(type: "integer", maxLength: 1000, nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    TotalCalories = table.Column<int>(type: "int", nullable: false),
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_FoodCategories_FoodCategoryID",
                        column: x => x.FoodCategoryID,
                        principalTable: "FoodCategories",
                        principalColumn: "FoodCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    TotalCaloriesByMeal = table.Column<int>(type: "integer", maxLength: 5000, nullable: false),
                    MealDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Menus_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menus_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuFoods",
                columns: table => new
                {
                    MenuFoodsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    FoodQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuFoods", x => x.MenuFoodsID);
                    table.ForeignKey(
                        name: "FK_MenuFoods_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuFoods_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryID", "FoodCategoryName" },
                values: new object[,]
                {
                    { 1, "Fruits" },
                    { 2, "Vegetables" },
                    { 3, "FastFoods" },
                    { 4, "Cheeses" },
                    { 5, "Meats" },
                    { 6, "Sweets" },
                    { 7, "Beverages" },
                    { 8, "Cereals" },
                    { 9, "Legumes" },
                    { 10, "Edible oils and fats" },
                    { 11, "Milk and milk products" },
                    { 12, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealID", "MealName" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonID", "ActivityStatus", "BirthDate", "CaloriesPerDay", "FirstName", "Gender", "Height", "LastName", "Password", "UserName", "UserStatus", "UserType", "Weight" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "Emre", 1, 0.0, "Bekfilavi", "1234", "Admin1", 1, 2, 85.5 },
                    { 2, 2, new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "Barış", 1, 0.0, "Erdem", "12345", "Admin2", 1, 2, 85.5 },
                    { 3, 2, new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "Recep", 1, 0.0, "Öztuna", "123456", "Admin3", 1, 2, 85.5 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "FoodCategoryID", "Grams", "Name", "PicturePath", "Portion", "Quantity", "TotalCalories" },
                values: new object[,]
                {
                    { 1, 39, 1, 100, "Şeftali", null, 2, 1, 0 },
                    { 2, 69, 1, 100, "Üzüm", null, 2, 1, 0 },
                    { 3, 32, 1, 100, "Çilek", null, 2, 1, 0 },
                    { 4, 115, 1, 100, "Zeytin", null, 2, 1, 0 },
                    { 5, 89, 1, 100, "Muz", null, 2, 1, 0 },
                    { 6, 52, 1, 100, "Elma", null, 2, 1, 0 },
                    { 7, 47, 1, 100, "Portakal", null, 2, 1, 0 },
                    { 8, 53, 1, 100, "Mandalina", null, 2, 1, 0 },
                    { 9, 83, 1, 100, "Nar", null, 2, 1, 0 },
                    { 10, 29, 1, 100, "Limon", null, 2, 1, 0 },
                    { 11, 48, 1, 100, "Kayısı", null, 2, 1, 0 },
                    { 12, 74, 1, 100, "İncir", null, 2, 1, 0 },
                    { 13, 46, 1, 100, "Erik", null, 2, 1, 0 },
                    { 14, 57, 1, 100, "Ayva", null, 2, 1, 0 },
                    { 15, 160, 1, 100, "Avakado", null, 2, 1, 0 },
                    { 16, 50, 1, 100, "Ananas", null, 2, 1, 0 },
                    { 17, 50, 1, 100, "Kiraz", null, 2, 1, 0 },
                    { 18, 61, 1, 100, "Kivi", null, 2, 1, 0 },
                    { 19, 33, 2, 100, "Bamya", null, 2, 1, 0 },
                    { 20, 81, 2, 100, "Bezelye", null, 2, 1, 0 },
                    { 21, 27, 2, 100, "Biber", null, 2, 1, 0 },
                    { 22, 34, 2, 100, "Brokoli", null, 2, 1, 0 },
                    { 23, 18, 2, 100, "Domates", null, 2, 1, 0 },
                    { 24, 16, 2, 100, "Salatalık", null, 2, 1, 0 },
                    { 25, 47, 2, 100, "Enginar", null, 2, 1, 0 },
                    { 26, 41, 2, 100, "Havuç", null, 2, 1, 0 },
                    { 27, 23, 2, 100, "Ispanak", null, 2, 1, 0 },
                    { 28, 61, 2, 100, "Pırasa", null, 2, 1, 0 },
                    { 29, 26, 2, 100, "Kabak", null, 2, 1, 0 },
                    { 30, 77, 2, 100, "Patates", null, 2, 1, 0 },
                    { 31, 22, 2, 100, "Mantar", null, 2, 1, 0 },
                    { 32, 96, 2, 100, "Mısır", null, 2, 1, 0 },
                    { 33, 25, 2, 100, "Patlıcan", null, 2, 1, 0 },
                    { 34, 149, 2, 100, "Sarımsak", null, 2, 1, 0 },
                    { 35, 28, 2, 100, "Turp", null, 2, 1, 0 },
                    { 36, 254, 3, 100, "Hamburger", null, 2, 1, 0 },
                    { 37, 267, 3, 100, "Double Cheeseburger", null, 2, 1, 0 },
                    { 38, 231, 3, 100, "Burger King Whopper", null, 2, 1, 0 },
                    { 39, 263, 3, 100, "McDonalds Cheeseburger", null, 2, 1, 0 },
                    { 40, 296, 3, 100, "Tavuk Nugget", null, 2, 1, 0 },
                    { 41, 195, 3, 100, "Fish and Chips", null, 2, 1, 0 },
                    { 42, 254, 3, 100, "Patates Kızartması", null, 2, 1, 0 },
                    { 43, 256, 3, 100, "McDonalds Big Mac", null, 2, 1, 0 },
                    { 44, 403, 4, 100, "Cheddar", null, 2, 1, 0 },
                    { 45, 280, 4, 100, "Mozzarella", null, 2, 1, 0 },
                    { 46, 337, 4, 100, "Kaşar Peyniri", null, 2, 1, 0 },
                    { 47, 435, 4, 100, "Eski Kaşar Peyniri", null, 2, 1, 0 },
                    { 48, 363, 4, 100, "Tulum Peyniri", null, 2, 1, 0 },
                    { 49, 342, 4, 100, "Krem Peynir", null, 2, 1, 0 },
                    { 50, 364, 4, 100, "Keçi Peyniri", null, 2, 1, 0 },
                    { 51, 364, 4, 100, "Koyun Peyniri", null, 2, 1, 0 },
                    { 52, 98, 4, 100, "Cottage Peyniri", null, 2, 1, 0 },
                    { 53, 242, 5, 100, "Biftek", null, 2, 1, 0 },
                    { 54, 121, 5, 100, "Antrikot", null, 2, 1, 0 },
                    { 55, 138, 5, 100, "Bonfile", null, 2, 1, 0 },
                    { 56, 189, 5, 100, "Hindi", null, 2, 1, 0 },
                    { 57, 219, 5, 100, "Tavuk", null, 2, 1, 0 },
                    { 58, 276, 5, 100, "Kuzu Pirzola", null, 2, 1, 0 },
                    { 59, 196, 5, 100, "Domuz Eti", null, 2, 1, 0 },
                    { 60, 156, 5, 100, "Şinitzel", null, 2, 1, 0 },
                    { 61, 246, 5, 100, "Dana Kıyma", null, 2, 1, 0 },
                    { 62, 230, 5, 100, "Sosis", null, 2, 1, 0 },
                    { 63, 332, 5, 100, "Sucuk", null, 2, 1, 0 },
                    { 64, 336, 5, 100, "Salam", null, 2, 1, 0 },
                    { 65, 252, 6, 100, "Kek", null, 2, 1, 0 },
                    { 66, 403, 6, 100, "Donut", null, 2, 1, 0 },
                    { 67, 283, 6, 100, "Tiramisu", null, 2, 1, 0 },
                    { 68, 312, 6, 100, "Waffle", null, 2, 1, 0 },
                    { 69, 334, 6, 100, "Profiterol", null, 2, 1, 0 },
                    { 70, 134, 6, 100, "Sütlaç", null, 2, 1, 0 },
                    { 71, 402, 6, 100, "Baklava", null, 2, 1, 0 },
                    { 72, 378, 6, 100, "Muhallebi", null, 2, 1, 0 },
                    { 73, 251, 6, 100, "Puding", null, 2, 1, 0 },
                    { 74, 42, 7, 100, "Kola", null, 2, 1, 0 },
                    { 75, 35, 7, 100, "Fanta", null, 2, 1, 0 },
                    { 76, 42, 7, 100, "Sprite", null, 2, 1, 0 },
                    { 77, 35, 7, 100, "Ayran", null, 2, 1, 0 },
                    { 78, 1, 7, 100, "Çay", null, 2, 1, 0 },
                    { 79, 2, 7, 100, "Kahve", null, 2, 1, 0 },
                    { 80, 36, 7, 100, "IceTea", null, 2, 1, 0 },
                    { 81, 357, 8, 100, "Arpa Şehriye", null, 2, 1, 0 },
                    { 82, 370, 8, 100, "Noodle", null, 2, 1, 0 },
                    { 83, 260, 8, 100, "Erişte", null, 2, 1, 0 },
                    { 84, 370, 8, 100, "Makarna", null, 2, 1, 0 },
                    { 85, 200, 8, 100, "Mantı", null, 2, 1, 0 },
                    { 86, 375, 8, 100, "Yulaf Ezmesi", null, 2, 1, 0 },
                    { 87, 336, 8, 100, "Müsli", null, 2, 1, 0 },
                    { 88, 357, 8, 100, "Mısır Gevreği", null, 2, 1, 0 },
                    { 89, 364, 8, 100, "Buğday Ezmesi", null, 2, 1, 0 },
                    { 90, 376, 8, 100, "Kuskus", null, 2, 1, 0 },
                    { 91, 84, 9, 100, "Bakla", null, 2, 1, 0 },
                    { 92, 127, 9, 100, "Barbunya", null, 2, 1, 0 },
                    { 93, 164, 9, 100, "Nohut", null, 2, 1, 0 },
                    { 94, 341, 9, 100, "Kuru Fasulye", null, 2, 1, 0 },
                    { 95, 353, 9, 100, "Mercimek", null, 2, 1, 0 },
                    { 96, 31, 9, 100, "Yeşil Fasulye", null, 2, 1, 0 },
                    { 97, 135, 9, 100, "Börülce", null, 2, 1, 0 },
                    { 98, 884, 10, 100, "Zeytinyağı", null, 2, 1, 0 },
                    { 99, 884, 10, 100, "Ayçiçekyağı", null, 2, 1, 0 },
                    { 100, 884, 10, 100, "Kanola Yağı", null, 2, 1, 0 },
                    { 101, 876, 10, 100, "Tereyağı", null, 2, 1, 0 },
                    { 102, 717, 10, 100, "Margarin", null, 2, 1, 0 },
                    { 103, 884, 10, 100, "PalmYağı", null, 2, 1, 0 },
                    { 104, 884, 10, 100, "SusamYağı", null, 2, 1, 0 },
                    { 105, 496, 11, 100, "Süt Tozu", null, 2, 1, 0 },
                    { 106, 112, 11, 100, "Cacık", null, 2, 1, 0 },
                    { 107, 51, 11, 100, "Kefir", null, 2, 1, 0 },
                    { 108, 345, 11, 100, "Krema", null, 2, 1, 0 },
                    { 109, 90, 11, 100, "Sıcak Çikolata", null, 2, 1, 0 },
                    { 110, 13, 11, 100, "Badem Sütü", null, 2, 1, 0 },
                    { 111, 61, 11, 100, "Tam Yağlı Süt", null, 2, 1, 0 },
                    { 112, 50, 11, 100, "Az Yağlı Süt", null, 2, 1, 0 },
                    { 113, 42, 11, 100, "Yarım Yağlı Süt", null, 2, 1, 0 },
                    { 114, 266, 12, 100, "Beyaz Ekmek", null, 2, 1, 0 },
                    { 115, 220, 12, 100, "Çavdarlı Ekmek", null, 2, 1, 0 },
                    { 116, 247, 12, 100, "Tam Tahıllı Ekmek", null, 2, 1, 0 },
                    { 117, 406, 12, 100, "Kruvasan", null, 2, 1, 0 },
                    { 118, 208, 12, 100, "Su Böreği", null, 2, 1, 0 },
                    { 119, 193, 12, 100, "Tost", null, 2, 1, 0 },
                    { 120, 224, 12, 100, "Poğaça", null, 2, 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryID",
                table: "Foods",
                column: "FoodCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuFoods_FoodID",
                table: "MenuFoods",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuFoods_MenuID",
                table: "MenuFoods",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MealID",
                table: "Menus",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_PersonID",
                table: "Menus",
                column: "PersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodSales");

            migrationBuilder.DropTable(
                name: "MenuFoods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
