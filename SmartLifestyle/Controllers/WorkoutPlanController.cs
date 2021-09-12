using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmartLifestyle.BusinessLogic.Models;
using SmartLifestyle.BusinessLogic.Services;
using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmartLifestyle.Controllers
{
    public class WorkoutPlanController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        private readonly WorkoutPlannerService fitnessPlannerService;


        static HttpClient client = new HttpClient();

        public WorkoutPlanController(WorkoutPlannerService fitnessPlannerService, UserManager<IdentityUser> userManager)
        {
            this.fitnessPlannerService = fitnessPlannerService;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult WorkoutPlanner()
        {
           
            WorkoutPlannerViewModel viewModel = new WorkoutPlannerViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> WorkoutPlanner(WorkoutPlannerViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);

            int Cardio = viewModel.Cardio;
            int Weight = viewModel.Weight;
            int Plyo = viewModel.Plyo;
            int Laps = viewModel.Laps;
            int Machine = viewModel.Machine;
            int Band = viewModel.Band;
            int Bar = viewModel.Bar;
            int BodyWeight = viewModel.BodyWeight;
            int BosuBall = viewModel.BosuBalll;
            int Dumbbells = viewModel.Dumbbells;
            int Kettlebells = viewModel.Kettlebells;
            int Landmine = viewModel.Landmine;
            int Platform = viewModel.Platform;
            int SquatRack = viewModel.SquatRack;
            int Cable = viewModel.Cable;
            int MedicineBall = viewModel.MedicineBall;
            int Arms = viewModel.Arms;
            int Back = viewModel.Back;
            int Core = viewModel.Core;
            int FullBody = viewModel.FullBody;
            int Legs = viewModel.Legs;

            var fit = fitnessPlannerService.AddUserDetailsForFitness(userId, Cardio, Weight, Plyo, Laps, Machine, Band, Bar, BodyWeight, BosuBall,
            Dumbbells, Kettlebells, Landmine, Platform, SquatRack, Cable, MedicineBall, Arms, Back, Core, FullBody, Legs);

            HttpResponseMessage response = await client.GetAsync("http://192.168.0.128:5000/submit?Cardio="+viewModel.Cardio+"&Weight="+viewModel.Weight+"&Plyo="
                +viewModel.Plyo+"&Laps="+viewModel.Laps+"&Machine="+viewModel.Machine+"&Band="+viewModel.Band+"&Bar="+viewModel.Arms+"&BodyWeight="
                +viewModel.BodyWeight+"&BosuBall="+viewModel.BosuBalll+"&Dumbbells="+viewModel.Dumbbells+"&Kettlebells="+viewModel.Kettlebells
                +"&Landmine="+viewModel.Landmine+"&Platform="+viewModel.Platform+"&SquatRack="+viewModel.SquatRack+"&Cable="+viewModel.Cable
                +"&MedicineBall="+viewModel.MedicineBall+"&Arms="+viewModel.Arms+"&Back="+viewModel.Back+"&Core="
                +viewModel.Core+"&FullBody="+viewModel.FullBody+"&Legs="+viewModel.Legs);
            response.EnsureSuccessStatusCode();

            List<double> list = new List<double>();
            if (response.IsSuccessStatusCode)
            {
                string val1 =  await response.Content.ReadAsStringAsync();
                 list = JsonConvert.DeserializeObject<List<double>>(val1);

            }


            //IList<WorkoutPlan> workoutPlan = new List<WorkoutPlan>();
           
                WorkoutPlan workoutPlan1 = new WorkoutPlan();
                workoutPlan1.WorkoutId1 = list[0];
                workoutPlan1.WorkoutId2 = list[1];
                workoutPlan1.WorkoutId3 = list[2];
                workoutPlan1.WorkoutId4 = list[3];
                workoutPlan1.WorkoutId5 = list[4];
                workoutPlan1.WorkoutId6 = list[5];
                workoutPlan1.UserId = userId;

            if (!fitnessPlannerService.CheckIfWorkoutRoutineExists(userId))
            {
                fitnessPlannerService.AddWorkout(workoutPlan1);
            }
            else
            {
                fitnessPlannerService.UpdateWorkoutRoutine(userId, fitnessPlannerService.GetRoutineId(userId), workoutPlan1.WorkoutId1, workoutPlan1.WorkoutId2, workoutPlan1.WorkoutId3, workoutPlan1.WorkoutId4, workoutPlan1.WorkoutId5, workoutPlan1.WorkoutId6);
            }
                            

            return RedirectToAction("Workouts", "WorkoutPlan");
        }

        public IActionResult Workouts()
        {
            var userId = userManager.GetUserId(User);
            WholeWorkoutRoutineDTO wholeWorkoutRoutineDTO = new WholeWorkoutRoutineDTO();
            WorkoutDTO workoutDTO1 = new WorkoutDTO();
            WorkoutDTO workoutDTO2 = new WorkoutDTO();
            WorkoutDTO workoutDTO3 = new WorkoutDTO();
            WorkoutDTO workoutDTO4 = new WorkoutDTO();
            WorkoutDTO workoutDTO5 = new WorkoutDTO();
            WorkoutDTO workoutDTO6 = new WorkoutDTO();

            Workout workout1 = new Workout();
            Workout workout2 = new Workout();
            Workout workout3 = new Workout();
            Workout workout4 = new Workout();
            Workout workout5 = new Workout();
            Workout workout6 = new Workout();

            var workouts = fitnessPlannerService.GetWorkoutsByUserId(userId);
            if (workouts == null)
            {
                return RedirectToAction("OopsWorkouts", "WorkoutPlan");
            }
            else
            {
            
                workout1 = fitnessPlannerService.GetRoutineByWorkoutId(workouts.WorkoutId1);
                workout2 = fitnessPlannerService.GetRoutineByWorkoutId(workouts.WorkoutId2);
                workout3 = fitnessPlannerService.GetRoutineByWorkoutId(workouts.WorkoutId3);
                workout4 = fitnessPlannerService.GetRoutineByWorkoutId(workouts.WorkoutId4);
                workout5 = fitnessPlannerService.GetRoutineByWorkoutId(workouts.WorkoutId5);
                workout6 = fitnessPlannerService.GetRoutineByWorkoutId(workouts.WorkoutId6);

                workoutDTO1.id = workout1.Id;
                workoutDTO1.Exercise = workout1.Exercise;
                workoutDTO1.Equipment = workout1.Equipment;
                workoutDTO1.ExerciseType = workout1.ExerciseType;
                workoutDTO1.MajorMuscle = workout1.MajorMuscle;
                workoutDTO1.MinorMuscle = workout1.MinorMuscle;
                workoutDTO1.Image = workout1.Image;
                workoutDTO1.Notes = workout1.Notes;
                workoutDTO1.Modifications = workout1.Modifications;

                workoutDTO2.id = workout2.Id;
                workoutDTO2.Exercise = workout2.Exercise;
                workoutDTO2.Equipment = workout2.Equipment;
                workoutDTO2.ExerciseType = workout2.ExerciseType;
                workoutDTO2.MajorMuscle = workout2.MajorMuscle;
                workoutDTO2.MinorMuscle = workout2.MinorMuscle;
                workoutDTO2.Image = workout2.Image;
                workoutDTO2.Notes = workout2.Notes;
                workoutDTO2.Modifications = workout2.Modifications;

                workoutDTO3.id = workout3.Id;
                workoutDTO3.Exercise = workout3.Exercise;
                workoutDTO3.Equipment = workout3.Equipment;
                workoutDTO3.ExerciseType = workout3.ExerciseType;
                workoutDTO3.MajorMuscle = workout3.MajorMuscle;
                workoutDTO3.MinorMuscle = workout3.MinorMuscle;
                workoutDTO3.Image = workout3.Image;
                workoutDTO3.Notes = workout3.Notes;
                workoutDTO3.Modifications = workout3.Modifications;

                workoutDTO4.id = workout4.Id;
                workoutDTO4.Exercise = workout4.Exercise;
                workoutDTO4.Equipment = workout4.Equipment;
                workoutDTO4.ExerciseType = workout4.ExerciseType;
                workoutDTO4.MajorMuscle = workout4.MajorMuscle;
                workoutDTO4.MinorMuscle = workout4.MinorMuscle;
                workoutDTO4.Image = workout4.Image;
                workoutDTO4.Notes = workout4.Notes;
                workoutDTO4.Modifications = workout4.Modifications;

                workoutDTO5.id = workout5.Id;
                workoutDTO5.Exercise = workout5.Exercise;
                workoutDTO5.Equipment = workout5.Equipment;
                workoutDTO5.ExerciseType = workout5.ExerciseType;
                workoutDTO5.MajorMuscle = workout5.MajorMuscle;
                workoutDTO5.MinorMuscle = workout5.MinorMuscle;
                workoutDTO5.Image = workout5.Image;
                workoutDTO5.Notes = workout5.Notes;
                workoutDTO5.Modifications = workout5.Modifications;

                workoutDTO6.id = workout6.Id;
                workoutDTO6.Exercise = workout6.Exercise;
                workoutDTO6.Equipment = workout6.Equipment;
                workoutDTO6.ExerciseType = workout6.ExerciseType;
                workoutDTO6.MajorMuscle = workout6.MajorMuscle;
                workoutDTO6.MinorMuscle = workout6.MinorMuscle;
                workoutDTO6.Image = workout6.Image;
                workoutDTO6.Notes = workout6.Notes;
                workoutDTO6.Modifications = workout6.Modifications;


                wholeWorkoutRoutineDTO.workout1 = workoutDTO1;
                wholeWorkoutRoutineDTO.workout2 = workoutDTO2;
                wholeWorkoutRoutineDTO.workout3 = workoutDTO3;
                wholeWorkoutRoutineDTO.workout4 = workoutDTO4;
                wholeWorkoutRoutineDTO.workout5 = workoutDTO5;
                wholeWorkoutRoutineDTO.workout6 = workoutDTO6;

                return View(wholeWorkoutRoutineDTO);
            }

        }

        [HttpGet]
        public IActionResult ShowWorkout(double? id)
        {
            WholeWorkoutRoutineDTO viewModel = new WholeWorkoutRoutineDTO();

            if (id.HasValue)
            {
                Workout workout = fitnessPlannerService.GetRoutineByWorkoutId(id.Value);
                viewModel.workout1 = new WorkoutDTO(); 

                viewModel.id = workout.Id;
                viewModel.workout1.Exercise = workout.Exercise;
                viewModel.workout1.Image = workout.Image;
                viewModel.workout1.MajorMuscle = workout.MajorMuscle;
                viewModel.workout1.MinorMuscle = workout.MinorMuscle;
                viewModel.workout1.Equipment = workout.Equipment;
                viewModel.workout1.ExerciseType = workout.ExerciseType;
                viewModel.workout1.Notes = workout.Notes;
                viewModel.workout1.Modifications = workout.Modifications;

                viewModel.workout2 = new WorkoutDTO();

                viewModel.id = workout.Id;
                viewModel.workout2.Exercise = workout.Exercise;
                viewModel.workout2.Image = workout.Image;
                viewModel.workout2.MajorMuscle = workout.MajorMuscle;
                viewModel.workout2.MinorMuscle = workout.MinorMuscle;
                viewModel.workout2.Equipment = workout.Equipment;
                viewModel.workout2.ExerciseType = workout.ExerciseType;
                viewModel.workout2.Notes = workout.Notes;
                viewModel.workout2.Modifications = workout.Modifications;

                viewModel.workout3 = new WorkoutDTO();

                viewModel.id = workout.Id;
                viewModel.workout3.Exercise = workout.Exercise;
                viewModel.workout3.Image = workout.Image;
                viewModel.workout3.MajorMuscle = workout.MajorMuscle;
                viewModel.workout3.MinorMuscle = workout.MinorMuscle;
                viewModel.workout3.Equipment = workout.Equipment;
                viewModel.workout3.ExerciseType = workout.ExerciseType;
                viewModel.workout3.Notes = workout.Notes;
                viewModel.workout3.Modifications = workout.Modifications;

                viewModel.workout4 = new WorkoutDTO();

                viewModel.id = workout.Id;
                viewModel.workout4.Exercise = workout.Exercise;
                viewModel.workout4.Image = workout.Image;
                viewModel.workout4.MajorMuscle = workout.MajorMuscle;
                viewModel.workout4.MinorMuscle = workout.MinorMuscle;
                viewModel.workout4.Equipment = workout.Equipment;
                viewModel.workout4.ExerciseType = workout.ExerciseType;
                viewModel.workout4.Notes = workout.Notes;
                viewModel.workout4.Modifications = workout.Modifications;

                viewModel.workout5 = new WorkoutDTO();

                viewModel.id = workout.Id;
                viewModel.workout5.Exercise = workout.Exercise;
                viewModel.workout5.Image = workout.Image;
                viewModel.workout5.MajorMuscle = workout.MajorMuscle;
                viewModel.workout5.MinorMuscle = workout.MinorMuscle;
                viewModel.workout5.Equipment = workout.Equipment;
                viewModel.workout5.ExerciseType = workout.ExerciseType;
                viewModel.workout5.Notes = workout.Notes;
                viewModel.workout5.Modifications = workout.Modifications;

                viewModel.workout6 = new WorkoutDTO();

                viewModel.id = workout.Id;
                viewModel.workout6.Exercise = workout.Exercise;
                viewModel.workout6.Image = workout.Image;
                viewModel.workout6.MajorMuscle = workout.MajorMuscle;
                viewModel.workout6.MinorMuscle = workout.MinorMuscle;
                viewModel.workout6.Equipment = workout.Equipment;
                viewModel.workout6.ExerciseType = workout.ExerciseType;
                viewModel.workout6.Notes = workout.Notes;
                viewModel.workout6.Modifications = workout.Modifications;
                return View(viewModel);
            }
            else
            {
                return View();
            }
           
        }
        public IActionResult OopsWorkouts()
        {
            return View();
        }
        public IActionResult WorkoutFavorite(int id)
        {
            var userId = userManager.GetUserId(User);
            fitnessPlannerService.AddFavWorkout(userId, id);
            return RedirectToAction("GetAllWorkoutFavorite", "WorkoutPlan");
        }
        public IActionResult GetAllWorkoutFavorite()
        {
            var userId = userManager.GetUserId(User);
            IList<FavoriteWorkout> workouts = fitnessPlannerService.GetAllFavWorkouts(userId);
            if (workouts != null)
            {
                return View(workouts);
            }
            else
            {
                return View();
            }
            
        }
    }
}
