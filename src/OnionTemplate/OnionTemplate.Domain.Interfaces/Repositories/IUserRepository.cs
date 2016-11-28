using System;
using OnionTemplate.Domain.Models;
using OnionTemplate.Domain.Models.Data;

namespace OnionTemplate.Domain.Interfaces.Repositories
{
	/// <summary>
	/// Definition of a user repository
	/// </summary>
	public interface IUserRepository : IGenericRepository<User>
	{
		// TODO: add methods that are non-generic user-specific
	}
}
