using Microsoft.EntityFrameworkCore;
using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class WeekRepository : BaseRepository<Week>, IWeekRepository
    {
        public WeekRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }

        public bool CheckIfMealPlanExists(int startEvent, int endEvent, string userId)
        {
            //aici am facut chestia cu cuprins intre start si end
            var dbEntry = dbContext.Weeks.FirstOrDefault(s => s.StartEvent <= startEvent && s.EndEvent >= startEvent && s.UserId == userId);

            if (dbEntry != null)
                return true;
            return false;
        }

        public Week GetWeekByStartEvent(int startEvent, int endEvent, string userId, int offset, string month)
        {
            //refactored
            if (offset == 0)
            {
                return dbContext.Weeks.FirstOrDefault(s => s.EndEvent >= startEvent && s.Month == month && s.UserId == userId);
            }

            var offsetStart = startEvent + 7 * offset;
            var offsetEnd = endEvent + 7 * offset;
            if(offsetStart > 30)
            {
                offsetStart = offsetStart - 30;
            }
            if (offsetEnd > 30)
            {
                offsetEnd = offsetEnd - 30;
            }
            if (offsetStart < 0)
            {
                offsetStart = 30 + offsetStart;
            }
            if (offsetEnd < 0)
            {
                offsetEnd = 30 + offsetEnd;
            }

            if (offsetStart < offsetEnd)
                return dbContext.Weeks.FirstOrDefault(s => s.StartEvent < offsetStart && s.EndEvent > offsetStart && s.Month == month && s.UserId == userId);
            else if (offsetStart > offsetEnd) // s-a schimbat luna
            {
                month = calculateMonth(offset);
                return dbContext.Weeks.FirstOrDefault(s => s.StartEvent < offsetStart && s.EndEvent > offsetStart && s.Month == month && s.UserId == userId);
            }
            return null;
        }

        private string calculateMonth(int offset)
        {
            int offset2;
            if(offset > 0)
            {
                offset2 = 1;
            }
            else
            {
                offset2 = -1;
            }
            DateTime dt = DateTime.Now;
            string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            int currentMonthId = dt.Month;
            int offsetId = currentMonthId + offset2;
            return monthNames[offsetId-1];
        }

        public int GetWeekIdByUserIdAndStartEv(int startEvent, int endEvent, string userId)
        {
            //refactored
            return dbContext.Weeks.FirstOrDefault(s => s.StartEvent <= startEvent && s.EndEvent >= startEvent && s.UserId == userId).Id;
        }

        public void UpdateMeal(Week week, int id)
        {
            var item = dbContext.Weeks.FirstOrDefault(s => s.Id == id);

            item.MondayId = dbContext.Weeks.FirstOrDefault(s => s.Id == id).MondayId;
            item.Monday = dbContext.Mondays.FirstOrDefault(s => s.Id == item.MondayId);
            item.Monday.NutrientsId = dbContext.Mondays.FirstOrDefault(s => s.Id == item.MondayId).NutrientsId;
            item.Monday.Nutrients = dbContext.Nutrients.FirstOrDefault(s => s.Id == item.Monday.NutrientsId);
            item.Monday.Nutrients.Carbohydrates = week.Monday.Nutrients.Carbohydrates;
            item.Monday.Nutrients.Calories = week.Monday.Nutrients.Calories;
            item.Monday.Nutrients.Fat = week.Monday.Nutrients.Fat;
            item.Monday.Nutrients.Protein = week.Monday.Nutrients.Protein;
            item.Monday.Meal = dbContext.Meals.Where(s => s.MondayId == item.Monday.Id).ToList();
            item.Monday.Meal.Clear();
            foreach (var meal in week.Monday.Meal)
            {
                item.Monday.Meal.Add(meal);
            }

            item.TuesdayId = dbContext.Weeks.FirstOrDefault(s => s.Id == id).TuesdayId;
            item.Tuesday = dbContext.Tuesdays.FirstOrDefault(s => s.Id == item.TuesdayId);
            item.Tuesday.NutrientsId = dbContext.Tuesdays.FirstOrDefault(s => s.Id == item.TuesdayId).NutrientsId;
            item.Tuesday.Nutrients = dbContext.Nutrients.FirstOrDefault(s => s.Id == item.Tuesday.NutrientsId);
            item.Tuesday.Nutrients.Carbohydrates = week.Tuesday.Nutrients.Carbohydrates;
            item.Tuesday.Nutrients.Calories = week.Tuesday.Nutrients.Calories;
            item.Tuesday.Nutrients.Fat = week.Tuesday.Nutrients.Fat;
            item.Tuesday.Nutrients.Protein = week.Tuesday.Nutrients.Protein;
            item.Tuesday.Meal = dbContext.Meals.Where(s => s.TuesdayId == item.Tuesday.Id).ToList();
            item.Tuesday.Meal.Clear();
            foreach (var meal in week.Tuesday.Meal)
            {
                item.Tuesday.Meal.Add(meal);
            }

            item.WednesdayId = dbContext.Weeks.FirstOrDefault(s => s.Id == id).WednesdayId;
            item.Wednesday = dbContext.Wednesdays.FirstOrDefault(s => s.Id == item.WednesdayId);
            item.Wednesday.NutrientsId = dbContext.Wednesdays.FirstOrDefault(s => s.Id == item.WednesdayId).NutrientsId;
            item.Wednesday.Nutrients = dbContext.Nutrients.FirstOrDefault(s => s.Id == item.Wednesday.NutrientsId);
            item.Wednesday.Nutrients.Carbohydrates = week.Wednesday.Nutrients.Carbohydrates;
            item.Wednesday.Nutrients.Calories = week.Wednesday.Nutrients.Calories;
            item.Wednesday.Nutrients.Fat = week.Wednesday.Nutrients.Fat;
            item.Wednesday.Nutrients.Protein = week.Wednesday.Nutrients.Protein;
            item.Wednesday.Meal = dbContext.Meals.Where(s => s.WednesdayId == item.Wednesday.Id).ToList();
            item.Wednesday.Meal.Clear();
            foreach (var meal in week.Wednesday.Meal)
            {
                item.Wednesday.Meal.Add(meal);
            }

            item.ThursdayId = dbContext.Weeks.FirstOrDefault(s => s.Id == id).ThursdayId;
            item.Thursday = dbContext.Thursdays.FirstOrDefault(s => s.Id == item.ThursdayId);
            item.Thursday.NutrientsId = dbContext.Thursdays.FirstOrDefault(s => s.Id == item.ThursdayId).NutrientsId;
            item.Thursday.Nutrients = dbContext.Nutrients.FirstOrDefault(s => s.Id == item.Thursday.NutrientsId);
            item.Thursday.Nutrients.Carbohydrates = week.Thursday.Nutrients.Carbohydrates;
            item.Thursday.Nutrients.Calories = week.Thursday.Nutrients.Calories;
            item.Thursday.Nutrients.Fat = week.Thursday.Nutrients.Fat;
            item.Thursday.Nutrients.Protein = week.Thursday.Nutrients.Protein;
            item.Thursday.Meal = dbContext.Meals.Where(s => s.ThursdayId == item.Thursday.Id).ToList();
            item.Thursday.Meal.Clear();
            foreach (var meal in week.Thursday.Meal)
            {
                item.Thursday.Meal.Add(meal);
            }

            item.FridayId = dbContext.Weeks.FirstOrDefault(s => s.Id == id).FridayId;
            item.Friday = dbContext.Fridays.FirstOrDefault(s => s.Id == item.FridayId);
            item.Friday.NutrientsId = dbContext.Fridays.FirstOrDefault(s => s.Id == item.FridayId).NutrientsId;
            item.Friday.Nutrients = dbContext.Nutrients.FirstOrDefault(s => s.Id == item.Friday.NutrientsId);
            item.Friday.Nutrients.Carbohydrates = week.Friday.Nutrients.Carbohydrates;
            item.Friday.Nutrients.Calories = week.Friday.Nutrients.Calories;
            item.Friday.Nutrients.Fat = week.Friday.Nutrients.Fat;
            item.Friday.Nutrients.Protein = week.Friday.Nutrients.Protein;
            item.Friday.Meal = dbContext.Meals.Where(s => s.FridayId == item.Friday.Id).ToList();
            item.Friday.Meal.Clear(); 
            foreach(var meal in week.Friday.Meal)
            {
                item.Friday.Meal.Add(meal);
            }

            item.SaturdayId = dbContext.Weeks.FirstOrDefault(s => s.Id == id).SaturdayId;
            item.Saturday = dbContext.Saturdays.FirstOrDefault(s => s.Id == item.SaturdayId);
            item.Saturday.NutrientsId = dbContext.Saturdays.FirstOrDefault(s => s.Id == item.SaturdayId).NutrientsId;
            item.Saturday.Nutrients = dbContext.Nutrients.FirstOrDefault(s => s.Id == item.Saturday.NutrientsId);
            item.Saturday.Nutrients.Carbohydrates = week.Saturday.Nutrients.Carbohydrates;
            item.Saturday.Nutrients.Calories = week.Saturday.Nutrients.Calories;
            item.Saturday.Nutrients.Fat = week.Saturday.Nutrients.Fat;
            item.Saturday.Nutrients.Protein = week.Saturday.Nutrients.Protein;
            item.Saturday.Meal = dbContext.Meals.Where(s => s.SaturdayId == item.Saturday.Id).ToList();
            item.Saturday.Meal.Clear();
            foreach (var meal in week.Saturday.Meal)
            {
                item.Saturday.Meal.Add(meal);
            }

            item.SundayId = dbContext.Weeks.FirstOrDefault(s => s.Id == id).SundayId;
            item.Sunday = dbContext.Sundays.FirstOrDefault(s => s.Id == item.SundayId);
            item.Sunday.NutrientsId = dbContext.Sundays.FirstOrDefault(s => s.Id == item.SundayId).NutrientsId;
            item.Sunday.Nutrients = dbContext.Nutrients.FirstOrDefault(s => s.Id == item.Sunday.NutrientsId);
            item.Sunday.Nutrients.Carbohydrates = week.Sunday.Nutrients.Carbohydrates;
            item.Sunday.Nutrients.Calories = week.Sunday.Nutrients.Calories;
            item.Sunday.Nutrients.Fat = week.Sunday.Nutrients.Fat;
            item.Sunday.Nutrients.Protein = week.Sunday.Nutrients.Protein;
            item.Sunday.Meal = dbContext.Meals.Where(s => s.SundayId == item.Sunday.Id).ToList();
            item.Sunday.Meal.Clear();
            foreach (var meal in week.Sunday.Meal)
            {
                item.Sunday.Meal.Add(meal);
            }

            dbContext.SaveChanges();
        }
    }
}
