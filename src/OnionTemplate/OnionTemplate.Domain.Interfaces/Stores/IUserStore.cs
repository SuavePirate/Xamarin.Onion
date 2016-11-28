using OnionTemplate.Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplate.Domain.Interfaces.Stores
{
    /// <summary>
    /// Definition for a user data store
    /// </summary>
    public interface IUserStore : IGenericStore<User>
    {
    }
}
