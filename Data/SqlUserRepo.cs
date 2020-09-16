using System;
using System.Collections.Generic;
using System.Linq;
using MVCTestFormApp.Data;
using MVCTestFormApp.Models;

namespace MVCTestFormApp.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly DatabaseContext _context;

        public SqlUserRepo(DatabaseContext context)
        {
            _context = context;
        }

        public void CreateUser(User movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }
            _context.Users.Add(movie);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}