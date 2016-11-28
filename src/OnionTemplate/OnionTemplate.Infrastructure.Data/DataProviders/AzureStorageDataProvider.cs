using System;
using System.Threading.Tasks;
using OnionTemplate.Domain.Interfaces;
using OnionTemplate.Domain.Interfaces.DataProviders;

namespace OnionTemplate.Infrastructure.Data.DataProviders
{
	/// <summary>
	/// Example cloud storage provider that would upload data to Azure
	/// </summary>
	public class AzureStorageDataProvider : ICloudStorageProvider
	{
		public AzureStorageDataProvider()
		{
		}

		public Task<bool> StoreItem(object item)
		{
			throw new NotImplementedException();
		}
	}

	// If you wanted to switch your data provider from Azure to some other cloud provider,
	// all you would have to do is create another class that implements ICloudStorageProvider
	// and update the IoCConfig at the destination client
	//
	/// <summary>
	/// Example cloud storage provider that would upload data to AWS
	/// </summary>
	//public class AWSStorageDataProvider : ICloudStorageProvider
	//{
	//	public AWSStorageDataProvider()
	//	{
	//	}

	//	public Task<bool> StoreItem(object item)
	//	{
	//		throw new NotImplementedException();
	//	}
	//}
}
