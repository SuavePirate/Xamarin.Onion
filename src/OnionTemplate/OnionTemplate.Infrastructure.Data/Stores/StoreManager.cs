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
    /// Class that contains and manages stores
    /// </summary>
    public class StoreManager : IStoreManager
    {
        public IUserStore UserStore { get; }

        public StoreManager(IUserStore userStore)
        {
            UserStore = userStore;
        }

        // TODO: Have a way to make getting generic
        public IGenericStore<T> Set<T>()
        {
            if(typeof(T) == typeof(User))
            {
                return UserStore as BaseStore<T>;
            }
            return null;
        }
    }
}
