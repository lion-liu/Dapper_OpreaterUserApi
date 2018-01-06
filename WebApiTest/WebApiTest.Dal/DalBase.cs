using WebApiTest.IDal;

namespace WebApiTest.Dal
{
    public abstract class BaseDal
    {
        public IDbFactory DbFactory { get;}

        protected BaseDal(IDbFactory _dbFactroy)
        {
            DbFactory = _dbFactroy;
        }
    }
}