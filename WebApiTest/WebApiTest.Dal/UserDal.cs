using System.Collections.Generic;
using System.Linq;
using Dapper;
using WebApiTest.IDal;
using WebApiTest.Models;

namespace WebApiTest.Dal
{
    public class UserDal : BaseDal, IUserDal
    {
        public UserDal(IDbFactory dbFactroy) : base(dbFactroy)
        {

        }

        public bool Add(User user)
        {
            const string sql = @"
                insert into `User`
                (
                  `Id`,
                  `Name`
                )
                values(
                  @Id,
                  @Name
                )";

            using (var con = DbFactory.Create())
            {
                return con.Execute(sql, user) > 0;
            }
        }

        public bool Dlete(int id)
        {
            const string sql = @"
                delete from `User`
                where `Id` = @Id";

            using (var con = DbFactory.Create())
            {
                return con.Execute(sql, new User { Id = id }) > 0;
            }
        }

        public User Get(string name)
        {
            const string sql = @";
                select
                  `Id`,
                  `Name`
                from `User` where `Name` = @Name";

            using (var con = DbFactory.Create())
            {
                return con.Query<User>(sql, new User { Name = name }).FirstOrDefault();
            }
        }

        public IEnumerable<User> GetList()
        {
            const string sql = @";
                select
                  `Id`,
                  `Name`
                from `User`";

            using (var con = DbFactory.Create())
            {
                return con.Query<User>(sql);
            }
        }

        public bool Update(User user)
        {
            const string sql = @";
                update `User`
                set
                  `Name` = @Name
                where `Id` = @Id";

            using (var con = DbFactory.Create())
            {
                return con.Execute(sql, user) > 0;
            }
        }
    }
}