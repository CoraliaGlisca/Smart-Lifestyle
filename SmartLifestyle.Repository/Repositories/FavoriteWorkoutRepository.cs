using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class FavoriteWorkoutRepository : BaseRepository<FavoriteWorkout>, IFavoriteWorkoutRepository
    {
        public FavoriteWorkoutRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }


        public void AddFavWorkout(string userId, int Id)
        {
            var favWorkout = new FavoriteWorkout();
            var workout = dbContext.Workouts.FirstOrDefault(m => m.Id == Id);
            favWorkout.Workout = workout;
            //favWorkout.Workout = new Workout();
            favWorkout.WorkoutId = Id;
            //favWorkout.Workout.Equipment = workout.Equipment;
            //favWorkout.Workout.ExerciseType = workout.ExerciseType;
            //favWorkout.Workout.Exercise = workout.Exercise;
            //favWorkout.Workout.Image = workout.Image;
            //favWorkout.Workout.MajorMuscle = workout.MajorMuscle;
            //favWorkout.Workout.MinorMuscle = workout.MinorMuscle;
            //favWorkout.Workout.Notes = workout.Notes;
            //favWorkout.Workout.Modifications = workout.Modifications;
            favWorkout.UserId = userId;
            dbContext.FavoriteWorkouts.Add(favWorkout);
            dbContext.SaveChanges();
        }

        public IList<FavoriteWorkout> GetAllFavWorkouts(string userId)
        {
            var favWorkouts = dbContext.FavoriteWorkouts.Where(m => m.UserId == userId).ToList();
            foreach (var item in favWorkouts)
            {
                item.Workout = dbContext.Workouts.FirstOrDefault(m => m.Id == item.WorkoutId);
            }
            return favWorkouts;
            throw new NotImplementedException();
        }       
    }
}
