using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class WorkoutPlanRepository : BaseRepository<WorkoutPlan>, IWorkoutPlanRepository
    {
        public WorkoutPlanRepository(SmartLDbContext dbContext): base(dbContext)
        {

        }

        public bool CheckIfWorkoutRoutineExists(string userId)
        {
            var dbEntry = dbContext.WorkoutPlans.FirstOrDefault(s => s.UserId == userId);

            if (dbEntry != null)
                return true;
            return false;
        }

        public int GetRoutineId(string userId)
        {
            return dbContext.WorkoutPlans.FirstOrDefault(s => s.UserId == userId).Id;
        }

        public WorkoutPlan GetWorkoutsByUserId(string userId)
        {
            return dbContext.WorkoutPlans.FirstOrDefault(s => s.UserId == userId);
        }

        public void UpdatePlan(string userId, int id, double WorkoutId1, double WorkoutId2, double WorkoutId3, double WorkoutId4, double WorkoutId5, double WorkoutId6)
        {
            var item = dbContext.WorkoutPlans.FirstOrDefault(s => s.Id == id);

            item.Id         = dbContext.WorkoutPlans.FirstOrDefault(s => s.Id == id).Id;
            item.WorkoutId1 = dbContext.Workouts.FirstOrDefault(s => s.Id == WorkoutId1).Id;
            item.WorkoutId2 = dbContext.Workouts.FirstOrDefault(s => s.Id == WorkoutId2).Id;
            item.WorkoutId3 = dbContext.Workouts.FirstOrDefault(s => s.Id == WorkoutId3).Id;
            item.WorkoutId4 = dbContext.Workouts.FirstOrDefault(s => s.Id == WorkoutId4).Id;
            item.WorkoutId5 = dbContext.Workouts.FirstOrDefault(s => s.Id == WorkoutId5).Id;
            item.WorkoutId6 = dbContext.Workouts.FirstOrDefault(s => s.Id == WorkoutId6).Id;
            item.UserId     = dbContext.WorkoutPlans.FirstOrDefault(s => s.UserId == item.UserId).UserId;
            dbContext.SaveChanges();
        }
    }
}
