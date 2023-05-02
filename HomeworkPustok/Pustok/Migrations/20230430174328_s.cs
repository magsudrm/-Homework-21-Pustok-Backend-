using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReview_AspNetUsers_AppUserId",
                table: "BookReview");

            migrationBuilder.DropForeignKey(
                name: "FK_BookReview_Books_BookId",
                table: "BookReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookReview",
                table: "BookReview");

            migrationBuilder.RenameTable(
                name: "BookReview",
                newName: "BookReviews");

            migrationBuilder.RenameIndex(
                name: "IX_BookReview_BookId",
                table: "BookReviews",
                newName: "IX_BookReviews_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookReview_AppUserId",
                table: "BookReviews",
                newName: "IX_BookReviews_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookReviews",
                table: "BookReviews",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BasketItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_AppUserId",
                table: "BasketItems",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BookId",
                table: "BasketItems",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_AspNetUsers_AppUserId",
                table: "BookReviews",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_AspNetUsers_AppUserId",
                table: "BookReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookReviews",
                table: "BookReviews");

            migrationBuilder.RenameTable(
                name: "BookReviews",
                newName: "BookReview");

            migrationBuilder.RenameIndex(
                name: "IX_BookReviews_BookId",
                table: "BookReview",
                newName: "IX_BookReview_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookReviews_AppUserId",
                table: "BookReview",
                newName: "IX_BookReview_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookReview",
                table: "BookReview",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReview_AspNetUsers_AppUserId",
                table: "BookReview",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReview_Books_BookId",
                table: "BookReview",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
