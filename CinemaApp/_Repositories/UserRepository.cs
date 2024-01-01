using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Data;

namespace CinemaApp._Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly CinemaAppContext _context;

        public UserRepository(CinemaAppContext context)
        {
            _context = context;
        }

        public bool Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                return false;
            }
            return true;
        }
       
    }
}
