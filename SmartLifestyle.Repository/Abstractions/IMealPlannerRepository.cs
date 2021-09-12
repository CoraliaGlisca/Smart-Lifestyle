using System;
using System.Collections.Generic;
using System.Text;
using SmartLifestyle.Models.Model;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IMealPlannerRepository : IRepository<UserDetailsForMeal>
    {
        void UpdateUserDetails(string userId, string allergens, string diets, string excludedIngredients, int targetCalories);
        bool CheckIfUserDetailsExist(string userId);
    }
}
