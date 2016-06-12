// --------------------------------------------------------------------------------------------------------------------
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

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StocklistPage : ContentPage, INavigableXamarinFormsPage
	{
		public StocklistPage()
		{
			InitializeComponent();
		}

		public StocklistPage(StocklistPageViewModel model) : this()
		{
			BindingContext = model;
		}

		public void OnNavigatedTo(IDictionary<string, object> navigationParameters)
		{
			this.Show(navigationParameters);
		}
	}
}