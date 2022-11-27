using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CategoryName", "Deleted", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("25fb26a6-ea4f-49a2-ac91-4a53a3d634d5"), true, "T-shirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Goku Fases", 59.99m },
                    { new Guid("2cb56aef-1fa1-4179-af29-bffee6fd95d2"), true, "T-shirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true", "Camiseta No Internet", 69.9m },
                    { new Guid("33b2fff5-6cca-4a36-9cbc-c40c7f44244e"), true, "T-shirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m },
                    { new Guid("361aa13e-a085-4867-b4d7-d3e69e73fb81"), true, "Sweatshirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz Cobra Kai", 159.9m },
                    { new Guid("4dbfb74f-2c4f-486f-89f6-7f0c082282ec"), true, "Action Figure", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet", 359.99m },
                    { new Guid("55e38635-6c36-4b68-a00e-9d877e990a44"), true, "T-shirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee Benefits", 69.9m },
                    { new Guid("725d86a6-567c-482a-afa3-199f466c738e"), true, "T-shirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camiseta Elon Musk Spacex Marte Occupy Mars", 59.99m },
                    { new Guid("b293a747-4544-4f80-9a1c-d373ec86046b"), true, "Action Figure", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m },
                    { new Guid("c0092091-8140-45f3-b8ca-98b2f1e10e7b"), true, "T-shirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux Programador Masculina", 59.99m },
                    { new Guid("f0f6e37a-d532-4e77-9ed2-599627f0eca3"), true, "Action Figure", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars The Black", 189.99m },
                    { new Guid("f18e61b1-eb66-4e26-b74c-d48ae7fe025f"), true, "T-shirt", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m },
                    { new Guid("fab49c1b-7cd7-4e7b-8840-f27d08d51ed1"), true, "Book", false, "DESCRICAO", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Livro Star Talk – Neil DeGrasse Tyson", 49.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25fb26a6-ea4f-49a2-ac91-4a53a3d634d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cb56aef-1fa1-4179-af29-bffee6fd95d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33b2fff5-6cca-4a36-9cbc-c40c7f44244e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("361aa13e-a085-4867-b4d7-d3e69e73fb81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4dbfb74f-2c4f-486f-89f6-7f0c082282ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55e38635-6c36-4b68-a00e-9d877e990a44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("725d86a6-567c-482a-afa3-199f466c738e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b293a747-4544-4f80-9a1c-d373ec86046b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0092091-8140-45f3-b8ca-98b2f1e10e7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0f6e37a-d532-4e77-9ed2-599627f0eca3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f18e61b1-eb66-4e26-b74c-d48ae7fe025f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fab49c1b-7cd7-4e7b-8840-f27d08d51ed1"));
        }
    }
}
