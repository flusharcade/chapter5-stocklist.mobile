﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StocklistPage.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Pages
{
	using System.Collections.Generic;

	using Xamarin.Forms;
	using Xamarin.Forms.Xaml;

	using Stocklist.XamForms.UI;

	using Stocklist.Portable.ViewModels;

	/// <summary>
	/// Stocklist page.
	/// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StocklistPage : ContentPage, INavigableXamarinFormsPage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Stocklist.XamForms.Pages.StocklistPage"/> class.
		/// </summary>
		public StocklistPage()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Stocklist.XamForms.Pages.StocklistPage"/> class.
		/// </summary>
		/// <param name="model">Model.</param>
		public StocklistPage(StocklistPageViewModel model) : this()
		{
			BindingContext = model;
		}

		/// <summary>
		/// Called when navigated to
		/// </summary>
		/// <returns>The navigated to.</returns>
		/// <param name="navigationParameters">Navigation parameters.</param>
		public void OnNavigatedTo(IDictionary<string, object> navigationParameters)
		{
			this.Show(navigationParameters);
		}
	}
}