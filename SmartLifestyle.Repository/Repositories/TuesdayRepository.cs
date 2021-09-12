using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class TuesdayRepository : BaseRepository<Tuesday>, ITuesdayRepository
    {
        public TuesdayRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }
        public Tuesday GetTuesdayById(int? id)
        {
            return dbContext.Tuesdays.SingleOrDefault(s => s.Id == id);
        }
    }
}
