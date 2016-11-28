using System;
using OnionTemplate.Domain.Models;
using OnionTemplate.Domain.Models.Data;

namespace OnionTemplate.Domain.Interfaces.DataProviders
{
	/// <summary>
	/// Definition of a user data provider
	/// </summary>
	public interface IUserDataProvider : IGenericDataProvider<User>
	{
	}
}
 