using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplate.Domain.Interfaces.Stores
{
    /// <summary>
    /// Definition of a store manager
    /// </summary>
    public interface IStoreManager
    {
        IUserStore UserStore { get; }
        IGenericStore<T> Set<T>();
    }
}
