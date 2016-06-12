// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Droid
{
	using System;

	using Android.App;
	using Android.Content;
	using Android.Content.PM;
	using Android.Runtime;
	using Android.Views;
	using Android.Widget;
	using Android.OS;

	using Stocklist.Droid.Modules;
	using Stocklist.XamForms.Modules;

	using Stocklist.Portable.Modules;
	using Stocklist.Portable.Ioc;

	[Activity(Label = "Stocklist.Portable.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			initIoC();

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}

		private void initIoC()
		{
			IoC.CreateContainer();
			IoC.RegisterModule(new DroidModule());
			IoC.RegisterModule(new XamFormsModule());
			IoC.RegisterModule(new PortableModule());
			IoC.StartContainer();
		}
	}
}

