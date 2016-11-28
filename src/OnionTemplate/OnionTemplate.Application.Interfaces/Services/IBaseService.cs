using System;
using System.Collections.Generic;

namespace OnionTemplate.Application.Interfaces.Services
{
	/// <summary>
	/// Definition of a base service for shared business logic
	/// </summary>
	public interface IBaseService
	{
		/// <summary>
		/// Validate a model
		/// </summary>
		/// <param name="model">Model.</param>
		IEnumerable<string> Validate(object model);
	}
}
