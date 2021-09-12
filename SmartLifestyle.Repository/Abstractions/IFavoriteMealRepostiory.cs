
using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IFavoriteMealRepostiory :IRepository<FavoriteMeal>
    {
        public void AddFavMeal(string userId, int mealId);
        IList<FavoriteMeal> GetAllFavMEals(string userId);
    }
}
