using OnionTemplate.Domain.Interfaces.Stores;
using OnionTemplate.Domain.Models;
using OnionTemplate.Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplate.Infrastructure.Data.Stores
{
    /// <summary>
    /// Just stores users in memory
    /// </summary>
    public class UserStore : BaseStore<User>, IUserStore
    {
    }
}
