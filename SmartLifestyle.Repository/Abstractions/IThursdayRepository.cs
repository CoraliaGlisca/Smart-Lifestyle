using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IThursdayRepository : IRepository<Thursday>
    {
        public Thursday GetThursdayById(int? id);
    }
}
