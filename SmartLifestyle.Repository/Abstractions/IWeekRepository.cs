using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IWeekRepository : IRepository<Week>
    {
        public Week GetWeekByStartEvent(int startEvent, int endEvent, string userId, int offset, string month);
        public bool CheckIfMealPlanExists(int startEvent, int endEvent, string userId);

        public int GetWeekIdByUserIdAndStartEv(int startEvent, int endEvent, string userId);
        public void UpdateMeal(Week week, int id);
    }
}
