﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartLifestyle.Models.Model;

namespace SmartLifestyle.Models.Migrations
{
    [DbContext(typeof(SmartLDbContext))]
    [Migration("20210625230446_migr1")]
    partial class migr1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.FavoriteMeal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.ToTable("FavoriteMeals");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.FavoriteWorkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WorkoutId")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("FavoriteWorkouts");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Friday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId");

                    b.ToTable("Fridays");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FridayId")
                        .HasColumnType("int");

                    b.Property<int>("IdAPI")
                        .HasColumnType("int");

                    b.Property<string>("ImageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MondayId")
                        .HasColumnType("int");

                    b.Property<int>("ReadyInMinutes")
                        .HasColumnType("int");

                    b.Property<int?>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<int>("Servings")
                        .HasColumnType("int");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SundayId")
                        .HasColumnType("int");

                    b.Property<int?>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<int?>("WednesdayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FridayId");

                    b.HasIndex("MondayId");

                    b.HasIndex("SaturdayId");

                    b.HasIndex("SundayId");

                    b.HasIndex("ThursdayId");

                    b.HasIndex("TuesdayId");

                    b.HasIndex("WednesdayId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Monday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId");

                    b.ToTable("Mondays");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Nutrients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("Carbohydrates")
                        .HasColumnType("float");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Nutrients");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Saturday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId");

                    b.ToTable("Saturdays");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Sunday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId");

                    b.ToTable("Sundays");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Thursday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId");

                    b.ToTable("Thursdays");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Tuesday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId");

                    b.ToTable("Tuesdays");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.UserDetailsForMeal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExcludedIngredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TargetCalories")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserDetailsForDiets");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.UserDetailsForWorkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Arms")
                        .HasColumnType("int");

                    b.Property<int>("Back")
                        .HasColumnType("int");

                    b.Property<int>("Band")
                        .HasColumnType("int");

                    b.Property<int>("Bar")
                        .HasColumnType("int");

                    b.Property<int>("BodyWeight")
                        .HasColumnType("int");

                    b.Property<int>("BosuBall")
                        .HasColumnType("int");

                    b.Property<int>("Cable")
                        .HasColumnType("int");

                    b.Property<int>("Cardio")
                        .HasColumnType("int");

                    b.Property<int>("Core")
                        .HasColumnType("int");

                    b.Property<int>("Dumbbells")
                        .HasColumnType("int");

                    b.Property<int>("FullBody")
                        .HasColumnType("int");

                    b.Property<int>("Kettlebells")
                        .HasColumnType("int");

                    b.Property<int>("Landmine")
                        .HasColumnType("int");

                    b.Property<int>("Laps")
                        .HasColumnType("int");

                    b.Property<int>("Legs")
                        .HasColumnType("int");

                    b.Property<int>("Machine")
                        .HasColumnType("int");

                    b.Property<int>("MedicineBall")
                        .HasColumnType("int");

                    b.Property<int>("Platform")
                        .HasColumnType("int");

                    b.Property<int>("Plyo")
                        .HasColumnType("int");

                    b.Property<int>("SquatRack")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserDetailsForFitness");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.UserOffset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Offset")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserOffsets");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Wednesday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId");

                    b.ToTable("Wednesdays");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EndEvent")
                        .HasColumnType("int");

                    b.Property<int?>("FridayId")
                        .HasColumnType("int");

                    b.Property<int?>("MondayId")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<int>("StartEvent")
                        .HasColumnType("int");

                    b.Property<int?>("SundayId")
                        .HasColumnType("int");

                    b.Property<int?>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<int?>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WednesdayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FridayId");

                    b.HasIndex("MondayId");

                    b.HasIndex("SaturdayId");

                    b.HasIndex("SundayId");

                    b.HasIndex("ThursdayId");

                    b.HasIndex("TuesdayId");

                    b.HasIndex("WednesdayId");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Workout", b =>
                {
                    b.Property<double>("Id")
                        .HasColumnType("float");

                    b.Property<string>("Equipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MajorMuscle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinorMuscle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.WorkoutPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WorkoutId1")
                        .HasColumnType("float");

                    b.Property<double>("WorkoutId2")
                        .HasColumnType("float");

                    b.Property<double>("WorkoutId3")
                        .HasColumnType("float");

                    b.Property<double>("WorkoutId4")
                        .HasColumnType("float");

                    b.Property<double>("WorkoutId5")
                        .HasColumnType("float");

                    b.Property<double>("WorkoutId6")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WorkoutPlans");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.WorkoutsForPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutPlanId")
                        .HasColumnType("int");

                    b.Property<double?>("WorkoutsId")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutPlanId");

                    b.HasIndex("WorkoutsId");

                    b.ToTable("WorkoutsForPlans");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.FavoriteMeal", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.FavoriteWorkout", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Friday", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Nutrients", "Nutrients")
                        .WithMany()
                        .HasForeignKey("NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Meal", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Friday", null)
                        .WithMany("Meal")
                        .HasForeignKey("FridayId");

                    b.HasOne("SmartLifestyle.Models.Model.Monday", null)
                        .WithMany("Meal")
                        .HasForeignKey("MondayId");

                    b.HasOne("SmartLifestyle.Models.Model.Saturday", null)
                        .WithMany("Meal")
                        .HasForeignKey("SaturdayId");

                    b.HasOne("SmartLifestyle.Models.Model.Sunday", null)
                        .WithMany("Meal")
                        .HasForeignKey("SundayId");

                    b.HasOne("SmartLifestyle.Models.Model.Thursday", null)
                        .WithMany("Meal")
                        .HasForeignKey("ThursdayId");

                    b.HasOne("SmartLifestyle.Models.Model.Tuesday", null)
                        .WithMany("Meal")
                        .HasForeignKey("TuesdayId");

                    b.HasOne("SmartLifestyle.Models.Model.Wednesday", null)
                        .WithMany("Meal")
                        .HasForeignKey("WednesdayId");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Monday", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Nutrients", "Nutrients")
                        .WithMany()
                        .HasForeignKey("NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Saturday", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Nutrients", "Nutrients")
                        .WithMany()
                        .HasForeignKey("NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Sunday", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Nutrients", "Nutrients")
                        .WithMany()
                        .HasForeignKey("NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Thursday", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Nutrients", "Nutrients")
                        .WithMany()
                        .HasForeignKey("NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Tuesday", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Nutrients", "Nutrients")
                        .WithMany()
                        .HasForeignKey("NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Wednesday", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Nutrients", "Nutrients")
                        .WithMany()
                        .HasForeignKey("NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.Week", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.Friday", "Friday")
                        .WithMany()
                        .HasForeignKey("FridayId");

                    b.HasOne("SmartLifestyle.Models.Model.Monday", "Monday")
                        .WithMany()
                        .HasForeignKey("MondayId");

                    b.HasOne("SmartLifestyle.Models.Model.Saturday", "Saturday")
                        .WithMany()
                        .HasForeignKey("SaturdayId");

                    b.HasOne("SmartLifestyle.Models.Model.Sunday", "Sunday")
                        .WithMany()
                        .HasForeignKey("SundayId");

                    b.HasOne("SmartLifestyle.Models.Model.Thursday", "Thursday")
                        .WithMany()
                        .HasForeignKey("ThursdayId");

                    b.HasOne("SmartLifestyle.Models.Model.Tuesday", "Tuesday")
                        .WithMany()
                        .HasForeignKey("TuesdayId");

                    b.HasOne("SmartLifestyle.Models.Model.Wednesday", "Wednesday")
                        .WithMany()
                        .HasForeignKey("WednesdayId");
                });

            modelBuilder.Entity("SmartLifestyle.Models.Model.WorkoutsForPlan", b =>
                {
                    b.HasOne("SmartLifestyle.Models.Model.WorkoutPlan", "WorkoutPlan")
                        .WithMany("WorkoutsForPlans")
                        .HasForeignKey("WorkoutPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartLifestyle.Models.Model.Workout", "Workouts")
                        .WithMany("WorkoutsForPlans")
                        .HasForeignKey("WorkoutsId");
                });
#pragma warning restore 612, 618
        }
    }
}
