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
	using Stocklist.Portable.Location;

	using Stocklist.Portable.Repositories.GeocodingRepository;

	public class PortableModule : IModule
	{
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<MainPageViewModel> ().SingleInstance();
			builer.RegisterType<MapPageViewModel> ().SingleInstance();

			builer.RegisterType<Position> ().As<IPosition>().SingleInstance();

			builer.RegisterType<GeocodingRepository> ().As<IGeocodingRepository>().SingleInstance();
		}
	}
}