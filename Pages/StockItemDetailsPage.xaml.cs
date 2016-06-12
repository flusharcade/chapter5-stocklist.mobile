﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockItemDetailsPage.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Pages
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Xamarin.Forms;
	using Xamarin.Forms.Xaml;

	using Stocklist.XamForms.UI;

	using Stocklist.Portable.ViewModels;
	using Stocklist.Portable.Ioc;

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StockItemDetailsPage : ContentPage, INavigableXamarinFormsPage
	{
		public StockItemDetailsPage()
		{
			InitializeComponent();
		}

		public StockItemDetailsPage(Func<StockItemDetailsPageViewModel> modelFactory) : this()
		{
			BindingContext = modelFactory();
		}

		public void OnNavigatedTo(IDictionary<string, object> navigationParameters)
		{
			this.Show(navigationParameters);
		}
	}
}