using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace GProject.Core.Storage
{
    public abstract class RepositoryBase<T> 
        where T : IRepository
    {
        public IDbConnection GetConnection ()
        {
            // currently handling only two profiles, but extensible to other profiles/databases
            var connectionStr = this.GetType().GetInterfaces().Contains(typeof(IWriteRepository))
                ? ConnectionStringProvider.WriteConnection
                : ConnectionStringProvider.ReadConnection;
            
            return new SqlConnection(connectionStr);
        }
    }
}
