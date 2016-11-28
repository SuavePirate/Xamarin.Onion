using System;
using System.Collections.Generic;
using OnionTemplate.Application.Interfaces;
using OnionTemplate.Application.Interfaces.Services;

namespace OnionTemplate.Infrastructure.Business.Services
{
	/// <summary>
	/// Implementation of shared service calls
	/// </summary>
	public class BaseService : IBaseService
	{
		public BaseService()
		{
		}

		public IEnumerable<string> Validate(object model)
		{
            // TODO: do some validation against data annotations
            return null;
		}
	}
}
