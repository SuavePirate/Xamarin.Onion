using System;
namespace OnionTemplate.Application.Models.Input
{
	/// <summary>
	/// Input model for creating new user
	/// </summary>
	public class NewUser
	{
		public string Email { get; set; }
		public string FullName { get; set; }
	}
}
