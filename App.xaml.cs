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

	public partial class App : Application
	{
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

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

