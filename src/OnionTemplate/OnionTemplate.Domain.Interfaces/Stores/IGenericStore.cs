using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplate.Domain.Interfaces.Stores
{
    /// <summary>
    /// Definition for a generic data store
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericStore<T>
    {
        List<T> Data { get; set; }
    }
}
