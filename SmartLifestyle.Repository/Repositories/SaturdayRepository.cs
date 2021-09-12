using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class SaturdayRepository : BaseRepository<Saturday>, ISaturdayRepository
    {
        public SaturdayRepository(SmartLDbContext dbContext): base(dbContext)
        {

        }
        public Saturday GetSaturdayById(int? id)
        {
            return dbContext.Saturdays.SingleOrDefault(s => s.Id == id);
        }
    }
}
