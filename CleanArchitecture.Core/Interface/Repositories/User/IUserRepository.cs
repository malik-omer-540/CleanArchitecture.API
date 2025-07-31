using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interface.Repositories.User
{
    public interface IUserRepository
    {
        public Task<User> MyProperty { get; set; }
    }
}
