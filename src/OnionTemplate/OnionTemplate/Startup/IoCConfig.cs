using System;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using OnionTemplate.Application.Interfaces;
using OnionTemplate.Domain.Interfaces;
using OnionTemplate.Infrastructure.Business;
using OnionTemplate.Infrastructure.Data;
using OnionTemplate.ViewModels;
using OnionTemplate.Infrastructure.Data.Stores;
using OnionTemplate.Infrastructure.Data.Repositories;
using OnionTemplate.Infrastructure.Data.Repositories.Repositories;
using OnionTemplate.Domain.Interfaces.Repositories;
using OnionTemplate.Infrastructure.Business.Services;
using OnionTemplate.Application.Interfaces.Services;
using OnionTemplate.Infrastructure.Data.Providers.DataProviders;
using OnionTemplate.Domain.Interfaces.DataProviders;
using OnionTemplate.Infrastructure.Data.DataProviders;
using OnionTemplate.Domain.Interfaces.Stores;

namespace OnionTemplate
{
	/// <summary>
	/// Managing class for registering dependencies 
	/// Notes: You can change these registrations or add on to them in the native environments to inject native implementations
	/// You can also change these registrations in test projects to use test data with Dependency Injection
	/// </summary>
	public class IoCConfig
	{
		public IoCConfig()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
		}

		public void RegisterViewModels()
		{
			SimpleIoc.Default.Register<MainViewModel>();
		}

		public void RegisterRepositories()
		{
			SimpleIoc.Default.Register<IUserRepository, UserRepository>(); // this is where you would change the registration to use a different repository
		}

		public void RegisterServices()
		{
			SimpleIoc.Default.Register<IUserService, UserService>();
		}

		public void RegisterProviders()
		{
			SimpleIoc.Default.Register<IUserDataProvider, UserDataProvider>();
			SimpleIoc.Default.Register<ICloudStorageProvider, AzureStorageDataProvider>(); // this is where you would change the registration to use a different provider
		}

        public void RegisterStores()
        {
            SimpleIoc.Default.Register<IUserStore, UserStore>();
            SimpleIoc.Default.Register<IStoreManager, StoreManager>();
        }
	}
}
