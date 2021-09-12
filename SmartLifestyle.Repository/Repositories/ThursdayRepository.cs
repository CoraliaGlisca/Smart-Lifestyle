using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class ThursdayRepository : BaseRepository<Thursday>, IThursdayRepository
    {
        public ThursdayRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }
        public Thursday GetThursdayById(int? id)
        {
            return dbContext.Thursdays.SingleOrDefault(s => s.Id == id);
        }
    }
}
