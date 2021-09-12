using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartLifestyle.Models.Migrations
{
    public partial class migr1 : Migration
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
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories = table.Column<double>(nullable: false),
                    Protein = table.Column<double>(nullable: false),
                    Fat = table.Column<double>(nullable: false),
                    Carbohydrates = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetailsForDiets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Allergens = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: false),
                    ExcludedIngredients = table.Column<string>(nullable: true),
                    TargetCalories = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetailsForDiets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetailsForFitness",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Cardio = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Plyo = table.Column<int>(nullable: false),
                    Laps = table.Column<int>(nullable: false),
                    Machine = table.Column<int>(nullable: false),
                    Band = table.Column<int>(nullable: false),
                    Bar = table.Column<int>(nullable: false),
                    BodyWeight = table.Column<int>(nullable: false),
                    BosuBall = table.Column<int>(nullable: false),
                    Dumbbells = table.Column<int>(nullable: false),
                    Kettlebells = table.Column<int>(nullable: false),
                    Landmine = table.Column<int>(nullable: false),
                    Platform = table.Column<int>(nullable: false),
                    SquatRack = table.Column<int>(nullable: false),
                    Cable = table.Column<int>(nullable: false),
                    MedicineBall = table.Column<int>(nullable: false),
                    Arms = table.Column<int>(nullable: false),
                    Back = table.Column<int>(nullable: false),
                    Core = table.Column<int>(nullable: false),
                    FullBody = table.Column<int>(nullable: false),
                    Legs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetailsForFitness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOffsets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Offset = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOffsets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId1 = table.Column<double>(nullable: false),
                    WorkoutId2 = table.Column<double>(nullable: false),
                    WorkoutId3 = table.Column<double>(nullable: false),
                    WorkoutId4 = table.Column<double>(nullable: false),
                    WorkoutId5 = table.Column<double>(nullable: false),
                    WorkoutId6 = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<double>(nullable: false),
                    Exercise = table.Column<string>(nullable: true),
                    Equipment = table.Column<string>(nullable: true),
                    ExerciseType = table.Column<string>(nullable: true),
                    MajorMuscle = table.Column<string>(nullable: true),
                    MinorMuscle = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Modifications = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
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
                name: "Fridays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fridays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fridays_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mondays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mondays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mondays_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saturdays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saturdays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saturdays_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sundays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sundays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sundays_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thursdays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thursdays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thursdays_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tuesdays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuesdays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tuesdays_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wednesdays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wednesdays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wednesdays_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteWorkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteWorkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteWorkouts_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutsForPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId = table.Column<int>(nullable: false),
                    WorkoutsId = table.Column<double>(nullable: true),
                    WorkoutPlanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutsForPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutsForPlans_WorkoutPlans_WorkoutPlanId",
                        column: x => x.WorkoutPlanId,
                        principalTable: "WorkoutPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutsForPlans_Workouts_WorkoutsId",
                        column: x => x.WorkoutsId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAPI = table.Column<int>(nullable: false),
                    ImageType = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ReadyInMinutes = table.Column<int>(nullable: false),
                    Servings = table.Column<int>(nullable: false),
                    SourceUrl = table.Column<string>(nullable: true),
                    MondayId = table.Column<int>(nullable: true),
                    TuesdayId = table.Column<int>(nullable: true),
                    WednesdayId = table.Column<int>(nullable: true),
                    ThursdayId = table.Column<int>(nullable: true),
                    FridayId = table.Column<int>(nullable: true),
                    SaturdayId = table.Column<int>(nullable: true),
                    SundayId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Fridays_FridayId",
                        column: x => x.FridayId,
                        principalTable: "Fridays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Mondays_MondayId",
                        column: x => x.MondayId,
                        principalTable: "Mondays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Saturdays_SaturdayId",
                        column: x => x.SaturdayId,
                        principalTable: "Saturdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Sundays_SundayId",
                        column: x => x.SundayId,
                        principalTable: "Sundays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Thursdays_ThursdayId",
                        column: x => x.ThursdayId,
                        principalTable: "Thursdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Tuesdays_TuesdayId",
                        column: x => x.TuesdayId,
                        principalTable: "Tuesdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Wednesdays_WednesdayId",
                        column: x => x.WednesdayId,
                        principalTable: "Wednesdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weeks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MondayId = table.Column<int>(nullable: true),
                    TuesdayId = table.Column<int>(nullable: true),
                    WednesdayId = table.Column<int>(nullable: true),
                    ThursdayId = table.Column<int>(nullable: true),
                    FridayId = table.Column<int>(nullable: true),
                    SaturdayId = table.Column<int>(nullable: true),
                    SundayId = table.Column<int>(nullable: true),
                    StartEvent = table.Column<int>(nullable: false),
                    EndEvent = table.Column<int>(nullable: false),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weeks_Fridays_FridayId",
                        column: x => x.FridayId,
                        principalTable: "Fridays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Mondays_MondayId",
                        column: x => x.MondayId,
                        principalTable: "Mondays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Saturdays_SaturdayId",
                        column: x => x.SaturdayId,
                        principalTable: "Saturdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Sundays_SundayId",
                        column: x => x.SundayId,
                        principalTable: "Sundays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Thursdays_ThursdayId",
                        column: x => x.ThursdayId,
                        principalTable: "Thursdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Tuesdays_TuesdayId",
                        column: x => x.TuesdayId,
                        principalTable: "Tuesdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Wednesdays_WednesdayId",
                        column: x => x.WednesdayId,
                        principalTable: "Wednesdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteMeals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_FavoriteMeals_MealId",
                table: "FavoriteMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteWorkouts_WorkoutId",
                table: "FavoriteWorkouts",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Fridays_NutrientsId",
                table: "Fridays",
                column: "NutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_FridayId",
                table: "Meals",
                column: "FridayId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MondayId",
                table: "Meals",
                column: "MondayId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_SaturdayId",
                table: "Meals",
                column: "SaturdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_SundayId",
                table: "Meals",
                column: "SundayId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_ThursdayId",
                table: "Meals",
                column: "ThursdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_TuesdayId",
                table: "Meals",
                column: "TuesdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WednesdayId",
                table: "Meals",
                column: "WednesdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Mondays_NutrientsId",
                table: "Mondays",
                column: "NutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Saturdays_NutrientsId",
                table: "Saturdays",
                column: "NutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sundays_NutrientsId",
                table: "Sundays",
                column: "NutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Thursdays_NutrientsId",
                table: "Thursdays",
                column: "NutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tuesdays_NutrientsId",
                table: "Tuesdays",
                column: "NutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Wednesdays_NutrientsId",
                table: "Wednesdays",
                column: "NutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_FridayId",
                table: "Weeks",
                column: "FridayId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_MondayId",
                table: "Weeks",
                column: "MondayId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_SaturdayId",
                table: "Weeks",
                column: "SaturdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_SundayId",
                table: "Weeks",
                column: "SundayId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_ThursdayId",
                table: "Weeks",
                column: "ThursdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_TuesdayId",
                table: "Weeks",
                column: "TuesdayId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_WednesdayId",
                table: "Weeks",
                column: "WednesdayId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutsForPlans_WorkoutPlanId",
                table: "WorkoutsForPlans",
                column: "WorkoutPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutsForPlans_WorkoutsId",
                table: "WorkoutsForPlans",
                column: "WorkoutsId");
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
                name: "FavoriteMeals");

            migrationBuilder.DropTable(
                name: "FavoriteWorkouts");

            migrationBuilder.DropTable(
                name: "UserDetailsForDiets");

            migrationBuilder.DropTable(
                name: "UserDetailsForFitness");

            migrationBuilder.DropTable(
                name: "UserOffsets");

            migrationBuilder.DropTable(
                name: "Weeks");

            migrationBuilder.DropTable(
                name: "WorkoutsForPlans");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "WorkoutPlans");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "Fridays");

            migrationBuilder.DropTable(
                name: "Mondays");

            migrationBuilder.DropTable(
                name: "Saturdays");

            migrationBuilder.DropTable(
                name: "Sundays");

            migrationBuilder.DropTable(
                name: "Thursdays");

            migrationBuilder.DropTable(
                name: "Tuesdays");

            migrationBuilder.DropTable(
                name: "Wednesdays");

            migrationBuilder.DropTable(
                name: "Nutrients");
        }
    }
}
