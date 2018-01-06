using System.Collections.Generic;
using WebApiTest.Models;

namespace WebApiTest.IBll
{
    public interface IUserBll
    {
        IEnumerable<User> GetList();
        User Get(string name);
        bool Add(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
