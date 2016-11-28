using System;
using OnionTemplate.Domain.Interfaces;
using OnionTemplate.Domain.Models;
using OnionTemplate.Infrastructure.Data.DataProviders;
using OnionTemplate.Domain.Models.Data;
using OnionTemplate.Domain.Interfaces.DataProviders;

namespace OnionTemplate.Infrastructure.Data.Providers.DataProviders
{
	/// <summary>
	/// Example implementation of a data provider for user data
	/// </summary>
	public class UserDataProvider : GenericDataProvider<User>, IUserDataProvider
	{
		public UserDataProvider()
		{
		}
	}
}
