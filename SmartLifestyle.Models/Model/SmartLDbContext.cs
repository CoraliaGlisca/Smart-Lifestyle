using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class SmartLDbContext : IdentityDbContext
    {
        public SmartLDbContext(DbContextOptions<SmartLDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<UserDetailsForMeal> UserDetailsForDiets { get; set; }
        public virtual DbSet<UserDetailsForWorkout> UserDetailsForFitness { get; set; }
        public virtual DbSet<Monday> Mondays { get; set; }
        public virtual DbSet<Tuesday> Tuesdays { get; set; }
        public virtual DbSet<Wednesday> Wednesdays { get; set; }
        public virtual DbSet<Thursday> Thursdays { get; set; }
        public virtual DbSet<Friday> Fridays { get; set; }
        public virtual DbSet<Saturday> Saturdays { get; set; }
        public virtual DbSet<Sunday> Sundays { get; set; }
        public virtual DbSet<Week> Weeks { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Nutrients> Nutrients { get; set; }
        public virtual DbSet<Workout> Workouts { get; set; }
        public virtual DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public virtual DbSet<UserOffset> UserOffsets { get; set; }
        public virtual DbSet<FavoriteMeal> FavoriteMeals { get; set; }
        public virtual DbSet<FavoriteWorkout> FavoriteWorkouts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
