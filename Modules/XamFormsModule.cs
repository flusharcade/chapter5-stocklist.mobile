// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XamFormsModule.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Modules
{
	using System.Windows.Input;

	using Autofac;

	using Xamarin.Forms;

	using Stocklist.XamForms.Pages;
	using Stocklist.XamForms.UI;

	using Stocklist.Portable.Ioc;
	using Stocklist.Portable.UI;

	/// <summary>
	/// Xam forms module.
	/// </summary>
	public class XamFormsModule : IModule
	{
		#region Public Methods

		/// <summary>
		/// Register the specified builer.
		/// </summary>
		/// <param name="builer">Builer.</param>
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<MainPage> ().SingleInstance();
			builer.RegisterType<StocklistPage> ().SingleInstance();
			builer.RegisterType<StockItemDetailsPage>().InstancePerDependency();

			builer.RegisterType<Xamarin.Forms.Command> ().As<ICommand>().InstancePerDependency();

			builer.Register (x => new NavigationPage(x.Resolve<MainPage>())).AsSelf().SingleInstance();

			builer.RegisterType<NavigationService> ().As<INavigationService>().SingleInstance();
		}

		#endregion
	}
}