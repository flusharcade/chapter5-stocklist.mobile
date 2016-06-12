// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PortableModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.Modules
{
	using System;

	using Autofac;

	using Stocklist.Portable.Ioc;
	using Stocklist.Portable.ViewModels;
	using Stocklist.Portable.UI;

	using Stocklist.Portable.Repositories.StocklistRepository;

	/// <summary>
	/// Portable module.
	/// </summary>
	public class PortableModule : IModule
	{
		/// <summary>
		/// Register the specified builer.
		/// </summary>
		/// <param name="builer">Builer.</param>
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<MainPageViewModel> ().SingleInstance();
			builer.RegisterType<StocklistPageViewModel> ().SingleInstance();
			builer.RegisterType<StockItemDetailsPageViewModel>().InstancePerDependency();

			builer.RegisterType<StockItemViewModel>().InstancePerDependency();

			builer.RegisterType<StocklistRepository> ().As<IStocklistRepository>().SingleInstance();
		}
	}
}