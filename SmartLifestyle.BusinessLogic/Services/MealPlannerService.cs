using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Services
{
    public class MealPlannerService
    {
        private IMealPlannerRepository mealPlannerRepository;
        private IWeekRepository weekRepository;
        private IMondayRepository mondayRepository;
        private ITuesdayRepository tuesdayRepository;
        private IWednesdayRepository wednesdayRepository;
        private IThursdayRepository thursdayRepository;
        private IFridayRepository fridayRepository;
        private ISaturdayRepository saturdayRepository;
        private ISundayRepository sundayRepository;
        private IMealRepository mealRepository;
        private INutrientsRepository nutrientsRepository;
        private IUserOffsetRepository userOffsetRepository;
        private IFavoriteMealRepostiory favoriteMealRepostiory;

        public MealPlannerService(
            IMealPlannerRepository mealPlannerRepository, 
            IWeekRepository weekRepository, 
            IMondayRepository mondayRepository,
            ITuesdayRepository tuesdayRepository,
            IWednesdayRepository wednesdayRepository,
            IThursdayRepository thursdayRepository,
            IFridayRepository fridayRepository,
            ISaturdayRepository saturdayRepository,
            ISundayRepository sundayRepository,
            IMealRepository mealRepository,
            INutrientsRepository nutrientsRepository,
            IUserOffsetRepository userOffsetRepository,
            IFavoriteMealRepostiory favoriteMealRepostiory)
        {
            this.mealPlannerRepository = mealPlannerRepository;
            this.weekRepository        = weekRepository;
            this.mondayRepository      = mondayRepository;
            this.tuesdayRepository     = tuesdayRepository;
            this.wednesdayRepository   = wednesdayRepository;
            this.thursdayRepository    = thursdayRepository;
            this.fridayRepository      = fridayRepository;
            this.saturdayRepository    = saturdayRepository;
            this.sundayRepository      = sundayRepository;
            this.mealRepository        = mealRepository;
            this.nutrientsRepository   = nutrientsRepository;
            this.userOffsetRepository  = userOffsetRepository;
            this.favoriteMealRepostiory = favoriteMealRepostiory;
        }

        public UserDetailsForMeal AddUserDetailsForMeal(  
            string userId, 
            string allergens, 
            string diet, 
            string unwantedIngredients,
            int targetCalories
            )
        {
            var dets = mealPlannerRepository.Add(new UserDetailsForMeal()
            {
                //Id = id,
                UserId    = userId,
                Allergens = allergens,
                Diet      = diet,
                ExcludedIngredients = unwantedIngredients,
                TargetCalories = targetCalories,
                //StartEvent = startEvent

            });
            return dets;
        }

        //public void UpdateUserDetails(UserDetailsForMeal userDetails)
        //{
        //    mealPlannerRepository.UpdateUserDetails(userDetails);
        //}

        public bool CheckIfUserDetailsExist(string userId)
        {
            return mealPlannerRepository.CheckIfUserDetailsExist(userId);
        }

        public void AddMeal( Week week)
        {
            weekRepository.Add(week);
         
        }

        public Week GetWeekByStartEvent(int startEvent, int endEvent, string userId, int offset, string month)
        {
            
            Week week   = weekRepository.GetWeekByStartEvent(startEvent, endEvent, userId, offset, month);
            if(week == null)
            {
                return null;
            }
            else
            {
                week.Monday = mondayRepository.GetMondayById(week.MondayId);
                week.Tuesday = tuesdayRepository.GetTuesdayById(week.TuesdayId);
                week.Wednesday = wednesdayRepository.GetWednesdayById(week.WednesdayId);
                week.Thursday = thursdayRepository.GetThursdayById(week.ThursdayId);
                week.Friday = fridayRepository.GetFridayById(week.FridayId);
                week.Saturday = saturdayRepository.GetSaturdayById(week.SaturdayId);
                week.Sunday = sundayRepository.GetSundayById(week.SundayId);

                week.Monday.Meal = mealRepository.GetMealByMondayId(week.MondayId);
                week.Tuesday.Meal = mealRepository.GetMealByTuesdayId(week.TuesdayId);
                week.Wednesday.Meal = mealRepository.GetMealByWednesdayId(week.WednesdayId);
                week.Thursday.Meal = mealRepository.GetMealByThursdayId(week.ThursdayId);
                week.Friday.Meal = mealRepository.GetMealByFridayId(week.FridayId);
                week.Saturday.Meal = mealRepository.GetMealBySaturdayId(week.SaturdayId);
                week.Sunday.Meal = mealRepository.GetMealBySundayId(week.SundayId);

                week.Monday.Nutrients = nutrientsRepository.GetNutrientsByNutrientId(week.Monday.NutrientsId);
                week.Tuesday.Nutrients = nutrientsRepository.GetNutrientsByNutrientId(week.Tuesday.NutrientsId);
                week.Wednesday.Nutrients = nutrientsRepository.GetNutrientsByNutrientId(week.Wednesday.NutrientsId);
                week.Thursday.Nutrients = nutrientsRepository.GetNutrientsByNutrientId(week.Thursday.NutrientsId);
                week.Friday.Nutrients = nutrientsRepository.GetNutrientsByNutrientId(week.Friday.NutrientsId);
                week.Saturday.Nutrients = nutrientsRepository.GetNutrientsByNutrientId(week.Saturday.NutrientsId);
                week.Sunday.Nutrients = nutrientsRepository.GetNutrientsByNutrientId(week.Sunday.NutrientsId);

                return week;
            }
            
            //return mealRepository.GetWeekByStartEvent(startEvent);
        }

        public void UpdateMeal(Week week, int id)
        {
            weekRepository.UpdateMeal(week, id);
        }

        public bool CheckIfMealPlanExists(int startEvent, int endEvent, string userId)
        {
            return weekRepository.CheckIfMealPlanExists(startEvent, endEvent, userId);
        }

        public int GetWeekId(int startEvent, int endEvent, string userId)
        {
            return weekRepository.GetWeekIdByUserIdAndStartEv(startEvent, endEvent, userId);
        }

        public void SetOffsetToZero(string userId)
        {
            userOffsetRepository.SetOffsetToZero(userId);
        }

        public void UdateOffset(string userId, int offset)
        {
            userOffsetRepository.UpdateOffset(userId, offset);
        }

        public int GetOffsetByUserId(string userId)
        {
            return userOffsetRepository.GetOffsetByUserId(userId);
        }

        public void AddFavMeal(string userId, int mealId)
        {
            favoriteMealRepostiory.AddFavMeal(userId, mealId);
        }

        public IList<FavoriteMeal> GetAllFavMEals(string userId)
        {
            return favoriteMealRepostiory.GetAllFavMEals(userId);
        }

        //public void AddUserOffset(string userId, int offset)
        //{
        //    userOffsetRepository.AddUserOffset(userId, offset);
        //}

        public void AddUserOffset(UserOffset userOffset)
        {
            userOffsetRepository.AddUserOffset(userOffset);
        }
    }
}
