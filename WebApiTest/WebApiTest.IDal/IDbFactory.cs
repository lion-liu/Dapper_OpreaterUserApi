using System.Data;

namespace WebApiTest.IDal
{
    public interface IDbFactory
    {
        IDbConnection Create(bool open = true);
    }
}
