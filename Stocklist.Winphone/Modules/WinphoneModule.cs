// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WinphoneModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Winphone.Modules
{
	using Autofac;

    using Stocklist.Winphone.Extras;

    using Stocklist.Portable.Extras;
    using Stocklist.Portable.Ioc;

	public class WinphoneModule : IModule
	{
		public void Register(ContainerBuilder builer)
		{
            builer.RegisterType<WinphoneMethods>().As<IMethods>().SingleInstance();
		}
    }
}

