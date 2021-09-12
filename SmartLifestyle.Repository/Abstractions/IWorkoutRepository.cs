using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IWorkoutRepository : IRepository<Workout>
    {
        public Workout GetRoutineByWorkoutId(double workoutId);
    }
}
