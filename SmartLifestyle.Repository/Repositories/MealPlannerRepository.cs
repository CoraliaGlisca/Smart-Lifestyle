using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class MealPlannerRepository : BaseRepository<UserDetailsForMeal>, IMealPlannerRepository
    {
        public MealPlannerRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }

        public bool CheckIfUserDetailsExist(string userId)
        {
            var dbEntry = dbContext.UserDetailsForDiets.FirstOrDefault(s => s.UserId == userId);

            if (dbEntry != null)
                return true;
            return false;
        }

        public void UpdateUserDetails(string userId, string allergens, string diets, string excludedIngredients, int targetCalories)
        {
            throw new NotImplementedException();
        }
    }
}
