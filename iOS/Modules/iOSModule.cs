// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOSModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.iOS.Modules
{
	using Stocklist.Portable.Ioc;

	using Autofac;

	using Stocklist.iOS.Extras;

	using Stocklist.Portable.Extras;

	public class IOSModule : IModule
	{
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<IOSMethods>().As<IMethods>().SingleInstance();
		}
	}
}