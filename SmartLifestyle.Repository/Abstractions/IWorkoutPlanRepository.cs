using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IWorkoutPlanRepository: IRepository<WorkoutPlan>
    {
        public WorkoutPlan GetWorkoutsByUserId(string userId);
        public bool CheckIfWorkoutRoutineExists(string userId);
        public void UpdatePlan(string userId, int id, double WorkoutId1, double WorkoutId2, double WorkoutId3, double WorkoutId4, double WorkoutId5, double WorkoutId6);
        public int GetRoutineId(string userId);
    }
}
