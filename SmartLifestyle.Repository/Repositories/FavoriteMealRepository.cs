using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class FavoriteMealRepository : BaseRepository<FavoriteMeal>, IFavoriteMealRepostiory
    {
        public FavoriteMealRepository(SmartLDbContext dbContext): base(dbContext)
        {

        }

        public void AddFavMeal(string userId, int mealId)
        {
            var favMeal = new FavoriteMeal();
            var meal = dbContext.Meals.FirstOrDefault(m => m.IdAPI == mealId);
            favMeal.Meal = new Meal();
            favMeal.MealId = mealId;
            favMeal.Meal.IdAPI = meal.IdAPI;
            favMeal.Meal.ImageType = meal.ImageType;
            favMeal.Meal.Title = meal.Title;
            favMeal.Meal.ReadyInMinutes = meal.ReadyInMinutes;
            favMeal.Meal.Servings = meal.Servings;
            favMeal.UserId = userId;
            dbContext.FavoriteMeals.Add(favMeal);
            dbContext.SaveChanges();
        }

        public IList<FavoriteMeal> GetAllFavMEals(string userId)
        {

            var favMeals = dbContext.FavoriteMeals.Where(m => m.UserId == userId).ToList();
            foreach(var item in favMeals)
            {
                item.Meal = dbContext.Meals.FirstOrDefault(m => m.Id == item.MealId);
            }
            return favMeals;

        }

    }
}
