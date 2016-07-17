// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOSModule.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Droid.Modules
{
	using Autofac;

	using Stocklist.Droid.Extras;

	using Stocklist.Portable.Extras;
	using Stocklist.Portable.Ioc;

	/// <summary>
	/// Droid module.
	/// </summary>
	public class DroidModule : IModule
	{
		#region Public Methods

		/// <summary>
		/// Register the specified builer.
		/// </summary>
		/// <param name="builer">Builer.</param>
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<DroidMethods>().As<IMethods>().SingleInstance();
		}

		#endregion
	}
}