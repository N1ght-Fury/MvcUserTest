using System;
using System.Collections.Generic;
using System.Linq;
using MVCTestFormApp.Models;

namespace MVCTestFormApp.Data
{
    public class SqlCityRepo : ICityRepo
    {
        private readonly DatabaseContext _context;

        public SqlCityRepo(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetAllCities()
        {
            return _context.Cities.ToList();
        }

        public City GetCityById(int id)
        {
            return _context.Cities.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}