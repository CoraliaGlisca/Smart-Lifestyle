using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IMealRepository : IRepository<Meal>
    {
        public IList<Meal> GetMealByMondayId(int? id);
        public IList<Meal> GetMealByTuesdayId(int? id);
        public IList<Meal> GetMealByWednesdayId(int? id);
        public IList<Meal> GetMealByThursdayId(int? id);
        public IList<Meal> GetMealByFridayId(int? id);
        public IList<Meal> GetMealBySaturdayId(int? id);
        public IList<Meal> GetMealBySundayId(int? id);
    }
}
