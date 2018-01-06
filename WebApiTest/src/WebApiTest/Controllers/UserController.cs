using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.IBll;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        readonly IUserBll _userBll;

        public UserController(IUserBll userBll)
        {
            _userBll = userBll;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userBll.GetList();
        }

        [HttpGet("{name}")]
        public User Get(string name)
        {
            return _userBll.Get(name);
        }

        [HttpPost]
        public void Post([FromBody]User user)
        {
            if(user == null || string.IsNullOrEmpty(user.Name))
            {
                return;
            }

            _userBll.Add(user);
        }


        [HttpPut]
        public void Put([FromBody]User user)
        {
            if (user == null || user.Id < 0 || string.IsNullOrEmpty(user.Name))
            {
                return;
            }

            _userBll.Update(user);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userBll.Delete(id);
        }
    }
}