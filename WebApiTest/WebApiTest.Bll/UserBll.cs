using System.Collections.Generic;
using WebApiTest.IBll;
using WebApiTest.IDal;
using WebApiTest.Models;

namespace WebApiTest.Bll
{
    public class UserBll : IUserBll
    {
        readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public bool Add(User user)
        {
            return _userDal.Add(user);
        }

        public bool Delete(int id)
        {
            return _userDal.Dlete(id);
        }

        public User Get(string name)
        {
            return _userDal.Get(name);
        }

        public IEnumerable<User> GetList()
        {
            return _userDal.GetList();
        }

        public bool Update(User user)
        {
            return _userDal.Update(user);
        }
    }
}