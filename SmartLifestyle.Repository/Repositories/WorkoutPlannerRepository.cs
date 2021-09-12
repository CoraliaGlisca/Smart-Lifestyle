using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class WorkoutPlannerRepository :  BaseRepository<UserDetailsForWorkout>, IWorkoutPlannerRepository
    {
        public WorkoutPlannerRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }
    }
}
