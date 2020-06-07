using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caldo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    PizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    MaliOpis = table.Column<string>(nullable: true),
                    VelikiOpis = table.Column<string>(nullable: true),
                    Cena = table.Column<decimal>(nullable: false),
                    SlikaUrl = table.Column<string>(nullable: true),
                    SlikaThumbUrl = table.Column<string>(nullable: true),
                    Najprodavanija = table.Column<bool>(nullable: false),
                    NaStanju = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.PizzaId);
                    table.ForeignKey(
                        name: "FK_Pizza_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    PizzaId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizza",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItem",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItem", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_Pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizza",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Pizze", null },
                    { 2, "Sendvici", null },
                    { 3, "Palacinke", null },
                    { 4, "Rostilj", null }
                });

            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "PizzaId", "CategoryId", "Cena", "Ime", "MaliOpis", "NaStanju", "Najprodavanija", "SlikaThumbUrl", "SlikaUrl", "VelikiOpis" },
                values: new object[,]
                {
                    { 1, 1, 170m, "Margarita", "kecap, kackavalj, origano", true, true, "\\Images\\MenuThumb\\pica1mala.jpg", "\\Images\\Menu\\pica1.jpg", "Regardless what else comes atop your pizza, a few fresh basil leaves will taste amazing with it. This simple summertime pizza would make a delicious cookout appetizer or light dinner paired with a salad." },
                    { 32, 3, 250m, "Slana palacinka kajmak", "Prilozi: sunka, kajmak, kackavalj", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 33, 3, 350m, "Slana palacinka prsut", "Prilozi: sunka, prsut, kackavalj", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 34, 3, 300m, "Slana palacinka pecenica", "Prilozi: sunka, pecenica, kackavalj, pavlaka", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 35, 3, 300m, "Slana palacinka kulen", "Prilozi: sunka, kulen, pavlaka, kackavalj", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 36, 3, 300m, "Slana palacinka suvi vrat", "Prilozi: sunka, suvi vrat, pavlaka, kackavalj", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 37, 3, 300m, "Slana palacinka pecenica/kulen", "Prilozi: pecenica, kulen, kackavalj, pavlaka", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 38, 4, 240m, "Pljeskavica", "160g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 39, 4, 270m, "Cevapi", "5 komada, 160g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 40, 4, 320m, "Rolovani cevapi", "5 komada, 200g (meso i slanina)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 41, 4, 300m, "Pojacana pljeskavica", "200g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 42, 4, 310m, "Pljeskavica sa kajmakom", "190g (meso i kajmak)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 43, 4, 250m, "Pljeskavica u susamu", "180g (meso plus susam)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 44, 4, 350m, "Gurmanska pljeskavica", "300g (meso, kackavalj, crniluk, tucana paprika)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 45, 4, 350m, "Punjena pljeskavica", "300g (meso, kackavalj, sunka, kulen)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 46, 4, 280m, "Dimljena kobasica", "160g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 47, 4, 320m, "Bela vesalica", "200g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 48, 4, 400m, "Punjena bela vesalica", "300g (vesalica, senf, kackavalj, kulen, sunka)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 49, 4, 350m, "Dimljeni vrat", "180g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 50, 4, 300m, "Dimljena slanina", "160g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 51, 4, 230m, "Pileca dzigerica", "160g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 52, 4, 280m, "Rolovana pileca dzigerica", "200g (dzigerica plus slanina)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 53, 4, 300m, "Pileci file", "200g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 54, 4, 350m, "Rolovano pilece belo", "250g (file plus panceta)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 55, 4, 320m, "Pilece belo u susamu", "220g (pilece belo plus susam)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 56, 4, 350m, "Punjeni pileci file", "300g (file, kackavalj, sunka, kulen)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 31, 3, 230m, "Slana palacinka pavlaka", "Prilozi: sunka, pavlaka, kackavalj", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 30, 3, 160m, "Slatka palacinka nutela", "Prilog: nutela", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 29, 3, 140m, "Slatka palacinka krem", "Prilog: krem", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 28, 3, 130m, "Slatka palacinka marmelada", "Prilozi: marmelada po izboru(sipurak, breskva, kajsija, sljiva)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 2, 1, 220m, "Napolitana", "kecap, kackavalj, tunjevina, origano", true, false, "\\Images\\MenuThumb\\pica2mala.jpg", "\\Images\\Menu\\pica2.jpg", "Who doesn’t love a little extra cheese for the perfect cheese-pull picture? We sure do. You might want to check with your local pizza joint to see how much cheese actually comes with an “extra cheese” order, because apparently, it’s hotly debated." },
                    { 3, 1, 200m, "Capriciosa", "kecap, kackavalj, sunka, pecurke, origano", true, false, "\\Images\\MenuThumb\\pica3mala.jpg", "\\Images\\Menu\\pica3.jpg", "Ham is often paired with the aforementioned pineapple for Hawaiian pizzas, but it can be delicious with other toppings (we’re looking at you, meat-lovers’ pizza). For a fancier feel, try prosciutto, or Italian ham." },
                    { 4, 1, 200m, "Vegetariana", "kecap, kackavalj, pavlaka, pecurke, origano", true, false, "\\Images\\MenuThumb\\pica4mala.jpg", "\\Images\\Menu\\pica4.jpg", "Some prefer mild, others spicy, and Southerners Conecuh, but sausage is consistently a favorite pizza topping of Americans. This cast-iron pizza recipe gives you another reason to love that skillet." },
                    { 5, 1, 200m, "Romana", "kecap, kackavalj, sunka, masline, origano", true, false, "\\Images\\MenuThumb\\pica5mala.jpg", "\\Images\\Menu\\pica5.jpg", "Green, red, yellow, or orange, peppers add a missing crunchy element to chewy, cheesy pizza. This sheet-pan recipe is the easiest way to serve pizza to a crowd, which is code for, “You should have a pizza party.”" },
                    { 6, 1, 240m, "Quatro Stagione", "kecap, kackavalj, sunka, kobasica, pecurke, masline, jaje, origano", true, false, "\\Images\\MenuThumb\\pica6mala.jpg", "\\Images\\Menu\\pica6.jpg", "In case you haven’t noticed the trend, meat is always popular on top of pizzas. Whether you’re going for a dressier steak pizza, a kid-friendly cheeseburger pizza, or a pizza topped with meatballs (actually a thing), beef always has a place on pizza." },
                    { 7, 1, 240m, "Vesuvio", "kecap, kackavalj, sunka, slanina, jaje, pecurke, crni luk, origano", false, false, "\\Images\\MenuThumb\\pica7mala.jpg", "\\Images\\Menu\\pica7.jpg", "Spinach is a delicious way to add a little green to your pizza. Another popular green found on pizzas is arugula. Unlike spinach, which is usually cooked with the pizza, arugula is placed fresh on top of the pizza for a fresh, peppery pop. Try our Fig Flatbread for an arugula-topped pizza recipe." },
                    { 8, 1, 250m, "Kalcona(zatvorena pizza)", "kecap, kackavalj, sunka, pecurke, kobasica, origano", true, false, "\\Images\\MenuThumb\\pica8mala.jpg", "Images/Menu/pica8.jpg", "This earthy topping can be divisive in the kitchen, but many agree that it fits right in on a pizza, and this breakfast recipe is a perfect excuse to try eggs on a pizza. Spoiler: You’re going to love it." },
                    { 9, 1, 250m, "Diablo", "kecap, kackavalj, sunka, pecurke, pavlaka, kobasica, origano", true, false, "\\Images\\MenuThumb\\pica9mala.jpg", "Images/Menu/pica9.jpg", "The winner winner of weeknight meals goes well on pizzas, too! BBQ chicken, buffalo chicken, and chicken bacon ranch are common pizza orders that contain this protein." },
                    { 10, 1, 200m, "Mexicana", "kecap, kackavalj, sunka, pecurke, tobasko, feferone, origano", true, false, "\\Images\\MenuThumb\\pica10mala.jpg", "\\Images\\Menu\\pica10.jpg", "Whether they crisp up in the oven or go on the pizza caramelized, onions are a popular topping that add a little salty or a little sweet, depending how they’re prepared. Red onions often accompany barbecue chicken pizzas, while white and yellow onions are popular for supreme pizzas." },
                    { 11, 1, 250m, "Burini", "kecap, kackavalj, vrat, kajmak, pecurke, jaje, origano", false, false, "\\Images\\MenuThumb\\pica11mala.jpg", "\\Images\\Menu\\pica11.jpg", "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way." },
                    { 12, 1, 210m, "Posna Pizza", "kecap, pecurke, tunjevina, masline, origano", false, false, "\\Images\\MenuThumb\\pica12mala.jpg", "\\Images\\Menu\\pica12.jpg", "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way." },
                    { 13, 1, 250m, "Caldo Special", "kecap, kackavalj, prsut, sampinjoni, jaje, pavlaka, masline, origano", false, false, "\\Images\\MenuThumb\\pica13mala.jpg", "\\Images\\Menu\\pica13.jpg", "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way." },
                    { 57, 4, 290m, "Batak", "200g", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 14, 1, 250m, "Specijal", "kecap, kackavalj, vrat, kobasica, jaje, pecurke, luk, origano", false, false, "\\Images\\MenuThumb\\pica14mala.jpg", "\\Images\\Menu\\pica14.jpg", "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way." },
                    { 16, 2, 50m, "Sendvic prazan", "lepinja", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 17, 2, 240m, "Sendvic pecurke", "lepinja, kackavalj, sunka, pecurke salata", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 18, 2, 240m, "Sendvic ruska", "lepinja, kackavalj, sunka, ruska salata", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 19, 2, 240m, "Sendvic govedja", "lepinja, kackavalj, sunka, govedja salata", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 20, 2, 240m, "Sendvic pileca", "lepinja, kackavalj, sunka, pileca salata", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 21, 2, 320m, "Sendvic prsut", "lepinja, kackavalj, njegoski prsut, salata po izboru", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 22, 2, 290m, "Sendvic pecenica", "lepinja, kackavalj, pecenica, salata po izboru", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 23, 2, 290m, "Sendvic suvi vrat", "lepinja, kackavalj, suvi vrat, salata po izboru", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 24, 2, 300m, "Sendvic kulen", "lepinja, kackavalj, kulen, salata po izboru", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 25, 3, 70m, "Prazna palacinka", "Prazna palacinka bez priloga", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 26, 3, 140m, "Slatka palacinka orah", "Prilozi: orasi, smedji secer", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 27, 3, 130m, "Slatka palacinka med", "Prilog: med", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" },
                    { 15, 1, 250m, "Piroska", "kecap, kackavalj, sunka, pecurke, pavlaka, origano", false, false, "\\Images\\MenuThumb\\pica15mala.jpg", "\\Images\\Menu\\pica15.jpg", "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way." },
                    { 58, 4, 350m, "Punjeni batak", "300g (batak, pecurke, kackavalj, sunka)", true, true, "\\Images\\Carousel\\Rostilj.jpg", "\\Images\\Carousel\\Rostilj.jpg", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_PizzaId",
                table: "OrderDetail",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_CategoryId",
                table: "Pizza",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_PizzaId",
                table: "ShoppingCartItem",
                column: "PizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ShoppingCartItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
