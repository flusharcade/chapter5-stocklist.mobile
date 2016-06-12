// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

[assembly: Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]

namespace Stocklist.XamForms
{
	using Xamarin.Forms;

	using Stocklist.Portable.Ioc;

	/// <summary>
	/// The App.
	/// </summary>
	public partial class App : Application
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Stocklist.XamForms.App"/> class.
		/// </summary>
		public App()
		{
			InitializeComponent();

			// The Application ResourceDictionary is available in Xamarin.Forms 1.3 and later
			if (Application.Current.Resources == null)
			{
				Application.Current.Resources = new ResourceDictionary();
			}

			MainPage = IoC.Resolve<NavigationPage>();
		}

		/// <summary>
		/// Override the starting function
		/// </summary>
		/// <returns>The start.</returns>
		protected override void OnStart()
		{
			// Handle when your app starts
		}

		/// <summary>
		/// Override the OnSleep function
		/// </summary>
		/// <returns>The sleep.</returns>
		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		/// <summary>
		/// Overrides the OnResume function
		/// </summary>
		/// <returns>The resume.</returns>
		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

