// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SharedModule.cs" company="Health Connex">
//   Copyright (c) 2015 Health Connex All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Shared.Modules
{
	using System;
	using System.Net;
	using System.Net.Http;

	using ModernHttpClient;

	using Autofac;

	using Stocklist.Portable.Ioc;

	public sealed class SharedModule : IModule
	{
		#region Fields

		private bool isWindows;

		#endregion

		#region Constructors and Destructors

		public SharedModule(bool isWindows)
		{
			this.isWindows = isWindows;
		}

		#endregion

		#region Public Methods and Operators

		public void Register(ContainerBuilder builder)
		{
			HttpClientHandler clientHandler = this.isWindows ? new HttpClientHandler() : new NativeMessageHandler();
			clientHandler.UseCookies = false;
			clientHandler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
			builder.Register(cb => clientHandler).As<HttpClientHandler>().SingleInstance();
		}
			
		#endregion
	}
}