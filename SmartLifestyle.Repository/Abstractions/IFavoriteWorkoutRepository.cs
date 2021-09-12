using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IFavoriteWorkoutRepository : IRepository<FavoriteWorkout>
    {
        public void AddFavWorkout(string userId, int id);
        public IList<FavoriteWorkout> GetAllFavWorkouts(string userId);

    }
}
