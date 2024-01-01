using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp._Repositories
{
    public interface IUserRepository
    {
        bool Login(string username, string password);
    }
}
