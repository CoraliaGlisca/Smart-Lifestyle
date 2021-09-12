using SmartLifestyle.BusinessLogic.Models;
using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Services
{
    public class WorkoutPlannerService
    {
        private IWorkoutPlannerRepository fitnessPlannerRepository;
        private IWorkoutPlanRepository workoutPlanRepository;
        private IWorkoutRepository workoutRepository;
        private IFavoriteWorkoutRepository favoriteWorkoutRepository;

        public WorkoutPlannerService(
            IWorkoutPlannerRepository fitnessPlannerRepository, 
            IWorkoutPlanRepository workoutPlanRepository,
            IWorkoutRepository workoutRepository,
            IFavoriteWorkoutRepository favoriteWorkoutRepository)
        {
            this.fitnessPlannerRepository = fitnessPlannerRepository;
            this.workoutPlanRepository = workoutPlanRepository;
            this.workoutRepository = workoutRepository;
            this.favoriteWorkoutRepository = favoriteWorkoutRepository;
        }

        public UserDetailsForWorkout AddUserDetailsForFitness( string userId,
            int Cardio, int Weight, int Plyo, int Laps, int Machine, int Band, int Bar, int BodyWeight, int BosuBall,
            int Dumbbells, int Kettlebells, int Landmine, int Platform, int SquatRack, int Cable, int MedicineBall,
            int Arms, int Back, int Core, int FullBody, int Legs)
        {
            var dets = fitnessPlannerRepository.Add(new UserDetailsForWorkout()
            {
                UserId = userId,
                Cardio = Cardio,
                Weight = Weight,
                Plyo = Plyo,
                Laps = Laps,
                Machine = Machine,
                Band = Band,
                Bar = Bar,
                BodyWeight = BodyWeight,
                BosuBall = BosuBall,
                Dumbbells = Dumbbells,
                Kettlebells = Kettlebells,
                Landmine = Landmine,
                Platform = Platform,
                SquatRack = SquatRack,
                Cable = Cable,
                MedicineBall = MedicineBall,
                Arms = Arms,
                Back = Back,
                Core = Core,
                FullBody = FullBody,
                Legs = Legs,

            });
            return dets;            
        }

        public void AddWorkout(WorkoutPlan workoutPlan1)
        {
            workoutPlanRepository.Add(workoutPlan1);
        }

        public WorkoutPlan GetWorkoutsByUserId(string userId)
        {
            return workoutPlanRepository.GetWorkoutsByUserId(userId);
        }

        public Workout GetRoutineByWorkoutId(double workoutId)
        {
            return workoutRepository.GetRoutineByWorkoutId(workoutId);
        }

        public void AddFavWorkout(string userId, int id)
        {
            favoriteWorkoutRepository.AddFavWorkout(userId, id);
        }

        public IList<FavoriteWorkout> GetAllFavWorkouts(string userId)
        {
            return favoriteWorkoutRepository.GetAllFavWorkouts(userId);
        }

        public bool CheckIfWorkoutRoutineExists(string userId)
        {
            return workoutPlanRepository.CheckIfWorkoutRoutineExists(userId);
        }

        public void UpdateWorkoutRoutine(string userId, int id, double WorkoutId1, double WorkoutId2, double WorkoutId3, double WorkoutId4, double WorkoutId5, double WorkoutId6)
        {
            workoutPlanRepository.UpdatePlan(userId, id, WorkoutId1, WorkoutId2, WorkoutId3, WorkoutId4, WorkoutId5, WorkoutId6);
        }

        public int GetRoutineId(string userId)
        {
            return workoutPlanRepository.GetRoutineId(userId);
        }
    }
}
