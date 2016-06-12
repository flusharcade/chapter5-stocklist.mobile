// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XamFormsModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Modules
{
	using System;
	using System.Windows.Input;

	using Autofac;

	using Xamarin.Forms;

	using Stocklist.XamForms.Pages;
	using Stocklist.XamForms.UI;

	using Stocklist.Portable.Ioc;
	using Stocklist.Portable.UI;

	public class XamFormsModule : IModule
	{
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<MainPage> ().SingleInstance();
			builer.RegisterType<StocklistPage> ().SingleInstance();
			builer.RegisterType<StockItemDetailsPage>().InstancePerDependency();

			builer.RegisterType<Xamarin.Forms.Command> ().As<ICommand>().InstancePerDependency();

			builer.Register (x => new NavigationPage(x.Resolve<MainPage>())).AsSelf().SingleInstance();

			builer.RegisterType<NavigationService> ().As<INavigationService>().SingleInstance();
		}
	}
}

