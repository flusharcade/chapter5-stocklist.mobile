// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StocklistPage.cs" company="Flush Arcade">
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

	public partial class StocklistPage : ContentPage, INavigableXamarinFormsPage
	{
		private StocklistPageViewModel viewModel;

		public StocklistPage()
		{
			this.InitializeComponent();
		}

		public StocklistPage(StocklistPageViewModel model) : this()
		{
			this.BindingContext = model;
		}

		public void OnNavigatedTo(IDictionary<string, object> navigationParameters)
		{
			this.Show(navigationParameters);
		}
	}
}