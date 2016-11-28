using System;
using OnionTemplate.Domain.Models;
using OnionTemplate.Domain.Models.Enums;
using OnionTemplate.Domain.Models.Data;

namespace OnionTemplate.Application.Models.Transfer
{
	/// <summary>
	/// Data transfer object for a user
	/// </summary>
	public class UserTransferObject
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string FullName { get; set; }
		public UserRole Role { get; set; }

		public  UserTransferObject()
		{
			
		}
		public  UserTransferObject(User entity)
		{
			Id = entity.Id;
			Email = entity.Email;
			FullName = entity.FullName;
			Role = entity.Role;
		}
	}
}
