using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IWednesdayRepository : IRepository<Wednesday>
    {
        public Wednesday GetWednesdayById(int? id);
    }
}
