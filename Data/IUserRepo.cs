using System.Collections.Generic;
using MVCTestFormApp.Models;

namespace MVCTestFormApp.Data
{
    public interface IUserRepo
    {
        void CreateUser(User user);

        bool SaveChanges();
    }
}