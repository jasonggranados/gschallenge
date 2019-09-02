using GProject.Core.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GProject.Core.Domain;
using Dapper;

namespace GProject.Infrastructure.DataStore
{
    public class UserRepository : RepositoryBase<IUserRepository>, IUserRepository
    {
        public async Task<User> GetSingle(int userId)
        {
            const string query = @"
select * from [User] where Id = @UserId";

            using (var connection = GetConnection())
            {
                var result = await connection.QueryAsync<User>(query, new { UserId = userId });
                return result.FirstOrDefault();
            }
        }

        public IEnumerable<User> GetAll()
        {
            const string query = @"
select * from [User]";

            using (var connection = GetConnection())
            {
                return connection.Query<User>(query);
            }
        }

        public async Task<IEnumerable<Assignment>> GetAssignments(int userId)
        {
            const string query = @"
select up.ProjectId, up.UserId, p.Id, up.IsActive, up.AssignedDate, p.StartDate, p.EndDate, p.Credits
from UserProject as up
inner join Project p on p.Id = up.ProjectId
where up.UserId = @UserId";

            using (var connection = GetConnection())
            {
                return await connection.QueryAsync<Assignment>(query, new { UserId = userId });
            }
        }
    }
}
