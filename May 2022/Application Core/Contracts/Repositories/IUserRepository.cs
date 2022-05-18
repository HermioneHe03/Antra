using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Entities;

namespace Application_Core.Contracts.Repositories
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
