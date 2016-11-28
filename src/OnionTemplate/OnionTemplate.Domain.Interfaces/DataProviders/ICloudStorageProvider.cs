using System;
using System.Threading.Tasks;

namespace OnionTemplate.Domain.Interfaces.DataProviders
{
	/// <summary>
	/// Definition of data provider that stores objects in the cloud
	/// </summary>
	public interface ICloudStorageProvider
	{
		Task<bool> StoreItem(object item);
	}
}
