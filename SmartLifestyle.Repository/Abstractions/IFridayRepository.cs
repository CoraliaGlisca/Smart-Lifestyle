using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IFridayRepository : IRepository<Friday>
    {
        public Friday GetFridayById(int? id);
    }
}
