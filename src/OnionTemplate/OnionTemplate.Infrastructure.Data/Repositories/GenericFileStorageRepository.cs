using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OnionTemplate.Domain.Interfaces;
using OnionTemplate.Domain.Interfaces.Repositories;

namespace OnionTemplate.Infrastructure.Data.Repositories
{
	/// <summary>
	/// Implementation of generic repository using local file storage
	/// </summary>
	public class GenericFileStorageRepository<T> : IGenericRepository<T>
	{

		public void Add(T entity)
		{
			// TODO: implement file storage of serialized object for adding entity
			throw new NotImplementedException();
		}

		public void AddRange(IEnumerable<T> entities)
		{
			// TODO: implement file storage of serialized object for adding entities
			throw new NotImplementedException();
		}

		public Task CommitAsync()
		{
			// TODO: implement file storage of serialized object for saving changes
			throw new NotImplementedException();
		}

		public Task<T> FindAsync(Func<T, bool> predicate)
		{
			// TODO: implement file storage of serialized object for finding an entity
			throw new NotImplementedException();
		}

        public Task<IEnumerable<T>> GetAsync(Func<T, bool> predicate)
        {
            // TODO: implement file storage of serialized object for getting entities
            throw new NotImplementedException();
        }

        public void Remove(T entity)
		{
			// TODO: implement file storage of serialized object for removing entity
			throw new NotImplementedException();
		}

		public void RemoveRange(T entities)
		{
			// TODO: implement file storage of serialized object for removing entities
			throw new NotImplementedException();
		}
	}
}
