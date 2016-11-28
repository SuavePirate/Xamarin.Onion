using System;
using OnionTemplate.Domain.Interfaces;
using OnionTemplate.Domain.Models;
using OnionTemplate.Infrastructure.Data.Stores;
using OnionTemplate.Domain.Models.Data;
using OnionTemplate.Domain.Interfaces.Repositories;
using OnionTemplate.Domain.Interfaces.Stores;

namespace OnionTemplate.Infrastructure.Data.Repositories.Repositories
{
	/// <summary>
	/// Implementation of user data access layer
	/// </summary>
	public class UserRepository : GenericMemoryRepository<User>, IUserRepository 
	{
		public UserRepository(IStoreManager manager)
            : base(manager)
		{
		}
	}

	// If you want to use a different storage provider, it is as easy as switching the repository implementation out.
	// This commented example would use file storage instead of SQL Lite
	// Then be sure to change the dependency registration in the IoCConfig
	//
	//public class UserRepository : GenericFileStorageRepository<User>, IUserRepository
	//{
	//	public UserRepository()
	//	{
	//	}
	//}
}
