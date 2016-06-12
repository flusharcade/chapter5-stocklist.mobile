// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOSModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.iOS.Modules
{
	using Autofac;

	using Stocklist.iOS.Extras;

	using Stocklist.Portable.Extras;
	using Stocklist.Portable.Ioc;

	/// <summary>
	/// The iOS Module.
	/// </summary>
	public class IOSModule : IModule
	{
		/// <summary>
		/// Register the specified builer.
		/// </summary>
		/// <param name="builer">Builer.</param>
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<IOSMethods>().As<IMethods>().SingleInstance();
		}
	}
}