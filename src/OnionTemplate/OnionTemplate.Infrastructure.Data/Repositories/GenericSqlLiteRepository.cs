using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OnionTemplate.Domain.Interfaces;
using OnionTemplate.Domain.Interfaces.Repositories;

namespace OnionTemplate.Infrastructure.Data.Repositories
{
	/// <summary>
	/// Implementation of Generic repository using Sql lite storage
	/// </summary>
	public class GenericSqlLiteRepository<T> : IGenericRepository<T>
	{
		public void Add(T entity)
		{
			// TODO: implement sql lite query for adding entity
			throw new NotImplementedException();
		}

		public void AddRange(IEnumerable<T> entities)
		{
			// TODO: implement sql lite query for adding entities
			throw new NotImplementedException();
		}

		public Task CommitAsync()
		{
			// TODO: implement sql lite query for commiting changes
			throw new NotImplementedException();
		}

		public Task<T> FindAsync(Func<T, bool> predicate)
		{
			// TODO: implement sql lite query for finding an entity
			throw new NotImplementedException();
		}

        public Task<IEnumerable<T>> GetAsync(Func<T, bool> predicate)
        {
            // TODO: implement sql lite query for getting entities
            throw new NotImplementedException();
        }

        public void Remove(T entity)
		{
			// TODO: implement sql lite query for removing entity
			throw new NotImplementedException();
		}

		public void RemoveRange(T entities)
		{
			// TODO: implement sql lite query for removing entities
			throw new NotImplementedException();
		}
	}
}
