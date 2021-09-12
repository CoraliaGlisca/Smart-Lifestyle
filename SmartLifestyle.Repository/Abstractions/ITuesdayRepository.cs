using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface ITuesdayRepository : IRepository<Tuesday>
    {
        public Tuesday GetTuesdayById(int? id);
    }
}
