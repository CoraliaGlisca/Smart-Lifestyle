using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class MealRepository : BaseRepository<Meal>, IMealRepository
    {
        public MealRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }

        public IList<Meal> GetMealByFridayId(int? id)
        {
            return dbContext.Meals.Where(x => x.FridayId == id).ToList();
        }

        public IList<Meal> GetMealByMondayId(int? id)
        {
            return dbContext.Meals.Where(x => x.MondayId == id).ToList();
        }

        public IList<Meal> GetMealBySaturdayId(int? id)
        {
            return dbContext.Meals.Where(x => x.SaturdayId == id).ToList();
        }

        public IList<Meal> GetMealBySundayId(int? id)
        {
            return dbContext.Meals.Where(x => x.SundayId == id).ToList();
        }

        public IList<Meal> GetMealByThursdayId(int? id)
        {
            return dbContext.Meals.Where(x => x.ThursdayId == id).ToList();
        }

        public IList<Meal> GetMealByTuesdayId(int? id)
        {
            return dbContext.Meals.Where(x => x.TuesdayId == id).ToList();
        }

        public IList<Meal> GetMealByWednesdayId(int? id)
        {
            return dbContext.Meals.Where(x => x.WednesdayId == id).ToList();
        }
    }
}
