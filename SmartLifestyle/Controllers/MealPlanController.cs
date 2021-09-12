using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SmartLifestyle.BusinessLogic.Models;
using SmartLifestyle.BusinessLogic.Services;
using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SmartLifestyle.Controllers
{
    public class MealPlanController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        private readonly MealPlannerService mealPlannerService;

        static HttpClient client = new HttpClient();

        public MealPlanController(MealPlannerService mealPlannerService, UserManager<IdentityUser> userManager)
        {
            this.mealPlannerService = mealPlannerService;
            this.userManager = userManager;
            
        }
        [HttpGet]
        public IActionResult MealPlanner()
        {
            MealPlannerViewModel viewModel = new MealPlannerViewModel();
            return View(viewModel);
        }       

        public async Task<ActionResult> MealPlanner(MealPlannerViewModel mealPlannerViewModel)
        {            

            var userId = userManager.GetUserId(User);
            string Allergens = "";
            string Diets = "";
            string ExcludedIngredients = mealPlannerViewModel.ExcludedIngredients;
            int TargetCalories = mealPlannerViewModel.TargetCalories;
            string dateNow = DateTime.Now.ToString("dd MMMM");
            int startEvent = Int32.Parse(dateNow.Substring(0, 2));
            int endEvent = startEvent + 7;
            String Month = dateNow.Substring(3);


            if (mealPlannerViewModel.SelectedAllergens != null)
            {
                foreach (var item in mealPlannerViewModel.SelectedAllergens)
                {
                    Allergens = Allergens + " " + item;
                }
            }

            if (mealPlannerViewModel.SelectedDiets != null)
            {
                foreach (var item in mealPlannerViewModel.SelectedDiets)
                {
                    Diets = Diets + " " + item;
                }
            }
            

            string allergens = "";
            string diets = "";
            if (mealPlannerViewModel.SelectedAllergens != null)
            {
                foreach (string item in mealPlannerViewModel.SelectedAllergens)
                {
                    allergens = allergens + ", " + item;
                }
            }
            foreach (string item in mealPlannerViewModel.SelectedDiets)
            {
                diets = diets + ", " + item;
            }
            Root rootDTO = null;
            HttpResponseMessage response = await client.GetAsync("https://api.spoonacular.com/mealplanner/generate?apiKey=061ae7be95124e3a8d22ce08d7d628c9&timeFrame=week&targetCalories="
                +mealPlannerViewModel.TargetCalories+"&diet="+Diets+"&exclude="+Allergens+mealPlannerViewModel.ExcludedIngredients);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                rootDTO = await response.Content.ReadAsAsync<Root>();
            }
            else
            {
                return RedirectToAction("OopsMeal", "MealPlan");
            }


            IList<Meal> mealsM  = new List<Meal>();
            IList<Meal> mealsT  = new List<Meal>();
            IList<Meal> mealsW  = new List<Meal>();
            IList<Meal> mealsTh = new List<Meal>();
            IList<Meal> mealsF  = new List<Meal>();
            IList<Meal> mealsS  = new List<Meal>();
            IList<Meal> mealsSu = new List<Meal>();

            mealsM = rootDTO.week.monday.meals.Select(a => new Meal
            {
                IdAPI = a.id,

                ImageType = a.imageType,

                Title = a.title,

                ReadyInMinutes = a.readyInMinutes,

                Servings = a.servings,

                SourceUrl = "https://spoonacular.com/recipeImages/"+a.id+"-240x150."+a.imageType 
            }).ToList();

            mealsT = rootDTO.week.tuesday.meals.Select(a => new Meal
            {
                IdAPI = a.id,

                ImageType = a.imageType,

                Title = a.title,

                ReadyInMinutes = a.readyInMinutes,

                Servings = a.servings,

                SourceUrl = "https://spoonacular.com/recipeImages/" + a.id + "-240x150." + a.imageType

            }).ToList();

            mealsW = rootDTO.week.wednesday.meals.Select(a => new Meal
            {
                IdAPI = a.id,

                ImageType = a.imageType,

                Title = a.title,

                ReadyInMinutes = a.readyInMinutes,

                Servings = a.servings,

                SourceUrl = "https://spoonacular.com/recipeImages/" + a.id + "-240x150." + a.imageType

            }).ToList();

            mealsTh = rootDTO.week.thursday.meals.Select(a => new Meal
            {
                IdAPI = a.id,

                ImageType = a.imageType,

                Title = a.title,

                ReadyInMinutes = a.readyInMinutes,

                Servings = a.servings,

                SourceUrl = "https://spoonacular.com/recipeImages/" + a.id + "-240x150." + a.imageType

            }).ToList();

            mealsF = rootDTO.week.friday.meals.Select(a => new Meal
            {
                IdAPI = a.id,

                ImageType = a.imageType,

                Title = a.title,

                ReadyInMinutes = a.readyInMinutes,

                Servings = a.servings,

                SourceUrl = "https://spoonacular.com/recipeImages/" + a.id + "-240x150." + a.imageType

            }).ToList();

            mealsS = rootDTO.week.saturday.meals.Select(a => new Meal
            {
                IdAPI = a.id,

                ImageType = a.imageType,

                Title = a.title,

                ReadyInMinutes = a.readyInMinutes,

                Servings = a.servings,

                SourceUrl = "https://spoonacular.com/recipeImages/" + a.id + "-240x150." + a.imageType

            }).ToList();

            mealsSu = rootDTO.week.sunday.meals.Select(a => new Meal
            {
                IdAPI = a.id,

                ImageType = a.imageType,

                Title = a.title,

                ReadyInMinutes = a.readyInMinutes,

                Servings = a.servings,

                SourceUrl = "https://spoonacular.com/recipeImages/" + a.id + "-240x150." + a.imageType

            }).ToList();

            Nutrients nutrientsM = new Nutrients();
            Nutrients nutrientsT = new Nutrients();
            Nutrients nutrientsW = new Nutrients();
            Nutrients nutrientsTh = new Nutrients();
            Nutrients nutrientsF = new Nutrients();
            Nutrients nutrientsS = new Nutrients();
            Nutrients nutrientsSu = new Nutrients();

            nutrientsM.Calories = rootDTO.week.monday.nutrients.calories;
            nutrientsM.Carbohydrates = rootDTO.week.monday.nutrients.carbohydrates;
            nutrientsM.Fat = rootDTO.week.monday.nutrients.fat;
            nutrientsM.Protein = rootDTO.week.monday.nutrients.protein;

            nutrientsT.Calories = rootDTO.week.tuesday.nutrients.calories;
            nutrientsT.Carbohydrates = rootDTO.week.tuesday.nutrients.carbohydrates;
            nutrientsT.Fat = rootDTO.week.tuesday.nutrients.fat;
            nutrientsT.Protein = rootDTO.week.tuesday.nutrients.protein;

            nutrientsW.Calories = rootDTO.week.wednesday.nutrients.calories;
            nutrientsW.Carbohydrates = rootDTO.week.wednesday.nutrients.carbohydrates;
            nutrientsW.Fat = rootDTO.week.wednesday.nutrients.fat;
            nutrientsW.Protein = rootDTO.week.wednesday.nutrients.protein;

            nutrientsTh.Calories = rootDTO.week.thursday.nutrients.calories;
            nutrientsTh.Carbohydrates = rootDTO.week.thursday.nutrients.carbohydrates;
            nutrientsTh.Fat = rootDTO.week.thursday.nutrients.fat;
            nutrientsTh.Protein = rootDTO.week.thursday.nutrients.protein;

            nutrientsF.Calories = rootDTO.week.friday.nutrients.calories;
            nutrientsF.Carbohydrates = rootDTO.week.friday.nutrients.carbohydrates;
            nutrientsF.Fat = rootDTO.week.friday.nutrients.fat;
            nutrientsF.Protein = rootDTO.week.friday.nutrients.protein;

            nutrientsS.Calories = rootDTO.week.saturday.nutrients.calories;
            nutrientsS.Carbohydrates = rootDTO.week.saturday.nutrients.carbohydrates;
            nutrientsS.Fat = rootDTO.week.saturday.nutrients.fat;
            nutrientsS.Protein = rootDTO.week.saturday.nutrients.protein;

            nutrientsSu.Calories = rootDTO.week.sunday.nutrients.calories;
            nutrientsSu.Carbohydrates = rootDTO.week.sunday.nutrients.carbohydrates;
            nutrientsSu.Fat = rootDTO.week.sunday.nutrients.fat;
            nutrientsSu.Protein = rootDTO.week.sunday.nutrients.protein;

            Monday monday = new Monday();
            monday.Meal = mealsM;
            monday.Nutrients = nutrientsM;

            Tuesday tuesday = new Tuesday();
            tuesday.Meal = mealsT;
            tuesday.Nutrients = nutrientsT;

            Wednesday wednesday = new Wednesday();
            wednesday.Meal = mealsW;
            wednesday.Nutrients = nutrientsW;

            Thursday thursday = new Thursday();
            thursday.Meal = mealsTh;
            thursday.Nutrients = nutrientsTh;

            Friday friday = new Friday();
            friday.Meal = mealsF;
            friday.Nutrients = nutrientsF;

            Saturday saturday = new Saturday();
            saturday.Meal = mealsS;
            saturday.Nutrients = nutrientsS;

            Sunday sunday = new Sunday();
            sunday.Meal = mealsSu;
            sunday.Nutrients = nutrientsSu;

            Week week = new Week();

            week.Monday = monday;
            week.Tuesday = tuesday;
            week.Wednesday = wednesday;
            week.Thursday = thursday;
            week.Friday = friday;
            week.Saturday = saturday;
            week.Sunday = sunday;

            week.UserId = userId;
            week.StartEvent = startEvent;
            week.EndEvent = endEvent;
            week.Month = Month;


            UserOffset userOffset = new UserOffset();
            userOffset.UserId = userId;
            userOffset.Offset = 0;

            

            if (!mealPlannerService.CheckIfMealPlanExists(startEvent,endEvent, userId))
            {
                mealPlannerService.AddMeal(week);
            }
            else
            {
                mealPlannerService.UpdateMeal(week, mealPlannerService.GetWeekId(startEvent, endEvent, userId));
            }
            
            
            return RedirectToAction("Calendar", "MealPlan");            

        }

        [HttpGet]
        public IActionResult Calendar(int offset)
        {
            string dateNow = DateTime.Now.ToString("dd MMMM");
            int startEvent = Int32.Parse(dateNow.Substring(0, 2));
            int endEvent = 0;
            if (startEvent + 7 > 30)
            {

                endEvent = 7- (30 - startEvent); 
            }
            else
            {
                endEvent = startEvent + 7;
            }
            String Month = dateNow.Substring(3);

            var userId = userManager.GetUserId(User);
            if(offset == 0)
            {
                mealPlannerService.SetOffsetToZero(userId);
            }
            else
            {
                mealPlannerService.UdateOffset(userId, offset);
            }

            
            var currentOffset = mealPlannerService.GetOffsetByUserId(userId);


            var week = mealPlannerService.GetWeekByStartEvent(startEvent, endEvent, userId, currentOffset, Month);

            //UserOffset userOffset = new UserOffset();
            //userOffset.UserId = userId;
            //userOffset.Offset = 0;

            //mealPlannerService.AddUserOffset(userOffset);

            if (week == null)
            {
                return RedirectToAction("OopsMeal", "MealPlan");
            }
            else
            {
                return View(week);
            }

        }

        [HttpGet]
        public async Task<ActionResult> ShowRecipe(int? id)
        {
            BusinessLogic.RecipeModels.Root rootDTO = null;           
            HttpResponseMessage response = await client.GetAsync("https://api.spoonacular.com/recipes/"+id+"/information?apiKey=061ae7be95124e3a8d22ce08d7d628c9&includeNutrition=true");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                rootDTO = await response.Content.ReadAsAsync<BusinessLogic.RecipeModels.Root>();
            }
            rootDTO.IdMeal = id;
            return View(rootDTO);
        }

        public IActionResult ChatBot()
        {

            return View();
        }

        public ActionResult OopsMeal()
        {

            return View();
        }

        public IActionResult MealFavorite(int id)
        {
            var userId = userManager.GetUserId(User);
            mealPlannerService.AddFavMeal(userId, id);
            return RedirectToAction("GetAllMealFavorite");
        }
        public IActionResult GetAllMealFavorite()
        {
            var userId = userManager.GetUserId(User);
            IList<FavoriteMeal> meals = mealPlannerService.GetAllFavMEals(userId);
            return View(meals);
        }
    }
}
