using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class WorkoutRepository : BaseRepository<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(SmartLDbContext dbContext): base(dbContext)
        {

        }

        public Workout GetRoutineByWorkoutId(double workoutId)
        {
            return dbContext.Workouts.FirstOrDefault(s => s.Id == workoutId);
        }
     
    }
}
