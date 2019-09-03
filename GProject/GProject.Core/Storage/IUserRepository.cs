using GProject.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Core.Storage
{
    public interface IUserRepository : IReadRepository
    {
        Task<User> GetSingle(int userId);

        IEnumerable<User> GetAll();

        Task<IEnumerable<Assignment>> GetAssignments(int userId);
    }
}
