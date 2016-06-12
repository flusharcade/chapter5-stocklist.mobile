// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPage.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Pages
{
	using System;
	using System.Collections.Generic;
	using System.Windows.Input;

	using Xamarin.Forms;
	using Xamarin.Forms.Xaml;

	using Stocklist.XamForms.UI;

	using Stocklist.Portable.ViewModels;

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage, INavigableXamarinFormsPage
	{
		private bool _originalTemplate = true;

		private ControlTemplate _blackTemplate;

		private ControlTemplate _whiteTemplate;

		public static readonly BindableProperty StocklistCommandProperty = BindableProperty.Create("StocklistCommand", typeof(ICommand), typeof(MainPage), null);
		public static readonly BindableProperty ExitCommandProperty = BindableProperty.Create("ExitCommand", typeof(ICommand), typeof(MainPage), null);

		public ICommand StocklistCommand
		{
			get { return (ICommand)GetValue(StocklistCommandProperty); }
		}

		public ICommand ExitCommand
		{
			get { return (ICommand)GetValue(ExitCommandProperty); }
		}

		public MainPage()
		{
			InitializeComponent();

			_blackTemplate = (ControlTemplate)Application.Current.Resources["MainBlackTemplate"];
			_whiteTemplate = (ControlTemplate)Application.Current.Resources["MainWhiteTemplate"];
		}

		public MainPage(MainPageViewModel model) : this()
		{
			BindingContext = model;
		}

		public void OnNavigatedTo(IDictionary<string, object> navigationParameters)
		{
			this.Show(navigationParameters);
		}

		public void ChangeThemeClicked(object sender, EventArgs e)
		{
			_originalTemplate = !_originalTemplate;
			ControlTemplate = _originalTemplate ? _blackTemplate : _whiteTemplate;
			BackgroundColor = _originalTemplate ? Color.Black : Color.White;
		}
	}
}