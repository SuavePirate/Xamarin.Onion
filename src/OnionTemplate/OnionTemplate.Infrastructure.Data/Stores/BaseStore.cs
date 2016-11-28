using OnionTemplate.Domain.Interfaces.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplate.Infrastructure.Data.Stores
{
    /// <summary>
    /// Just a basic example of memory storage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseStore<T> : IGenericStore<T>
    {
        public List<T> Data { get; set; }
        public BaseStore()
        {
            Data = new List<T>();
        }
    }
}
