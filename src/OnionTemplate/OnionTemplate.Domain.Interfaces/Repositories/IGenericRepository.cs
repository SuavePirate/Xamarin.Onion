using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnionTemplate.Domain.Interfaces.Repositories
{
	/// <summary>
	/// Definition of a generic repository
	/// </summary>
	public interface IGenericRepository<T>
	{
		void Add(T entity);
		void AddRange(IEnumerable<T> entities);
		void Remove(T entity);
		void RemoveRange(T entities);
		Task<T> FindAsync(Func<T, bool> predicate);
        Task<IEnumerable<T>> GetAsync(Func<T, bool> predicate);
		Task CommitAsync();
	}
}