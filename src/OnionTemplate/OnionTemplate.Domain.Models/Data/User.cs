using OnionTemplate.Domain.Models.Enums;
using System;
namespace OnionTemplate.Domain.Models.Data
{
	/// <summary>
	/// Example user data model
	/// </summary>
	public class User
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string FullName { get; set; }
		public string PasswordHash { get; set; }
		public UserRole Role { get; set; }
	}
}
