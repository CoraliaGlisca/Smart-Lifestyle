using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartLifestyle.Models.Migrations
{
    public partial class migr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteWorkouts_Workouts_WorkoutId",
                table: "FavoriteWorkouts");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteWorkouts_WorkoutId",
                table: "FavoriteWorkouts");

            migrationBuilder.AlterColumn<int>(
                name: "WorkoutId",
                table: "FavoriteWorkouts",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<double>(
                name: "WorkoutId1",
                table: "FavoriteWorkouts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteWorkouts_WorkoutId1",
                table: "FavoriteWorkouts",
                column: "WorkoutId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteWorkouts_Workouts_WorkoutId1",
                table: "FavoriteWorkouts",
                column: "WorkoutId1",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteWorkouts_Workouts_WorkoutId1",
                table: "FavoriteWorkouts");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteWorkouts_WorkoutId1",
                table: "FavoriteWorkouts");

            migrationBuilder.DropColumn(
                name: "WorkoutId1",
                table: "FavoriteWorkouts");

            migrationBuilder.AlterColumn<double>(
                name: "WorkoutId",
                table: "FavoriteWorkouts",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteWorkouts_WorkoutId",
                table: "FavoriteWorkouts",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteWorkouts_Workouts_WorkoutId",
                table: "FavoriteWorkouts",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
