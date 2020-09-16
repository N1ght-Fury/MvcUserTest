using System.Collections.Generic;
using MVCTestFormApp.Models;

namespace MVCTestFormApp.Data
{
    public interface ICityRepo
    {
        IEnumerable<City> GetAllCities();
        City GetCityById(int id);
        bool SaveChanges();
    }
}