using System.Collections.Generic;
using WebApiTest.Models;

namespace WebApiTest.IDal
{
    public interface IUserDal
    {
        IEnumerable<User> GetList();
        User Get(string name);
        bool Add(User user);
        bool Update(User user);
        bool Dlete(int id);
    }
}
