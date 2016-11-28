using System;
using OnionTemplate.Domain.Models;
using OnionTemplate.Domain.Models.Data;
using OnionTemplate.Application.Models.Input;

namespace OnionTemplate.Application.Models.Extensions
{
	/// <summary>
	/// Extensions for model to model translation
	/// </summary>
	public static class UserExtensions
	{
		public static User ToUser(this NewUser model)
		{
			return new User
			{
				Email = model.Email,
				FullName = model.FullName
			};
		}
	}
}
