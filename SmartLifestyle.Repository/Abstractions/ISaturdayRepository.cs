using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface ISaturdayRepository : IRepository<Saturday>
    {
        public Saturday GetSaturdayById(int? id);
    }
}
