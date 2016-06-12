// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StocklistPageViewModel.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.ViewModels
{
	using System;
	using System.Reactive.Linq;
	using System.Linq;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Collections.ObjectModel;

	using Stocklist.Portable.UI;
	using Stocklist.Portable.Repositories.StocklistRepository;

	/// <summary>
	/// Stocklist page view model.
	/// </summary>
	public class StocklistPageViewModel : ViewModelBase
	{
		#region Private Properties

		private readonly IStocklistRepository _stocklistRepository;

		private readonly Func<StockItemViewModel> _stockItemFactory;

		private StockItemViewModel _selected;

		private bool _inProgress;

		#endregion

		#region Public Properties

		public ObservableCollection<StockItemViewModel> StockItems { get; set; }

		public StockItemViewModel Selected
		{
			get
			{
				return _selected;
			}

			set
			{
				if (value.Equals(_selected))
				{
					return;
				}
				else
				{
					Navigation.Navigate(Enums.PageNames.StockItemDetailsPage, new Dictionary<string, object>()
					{
						{"id", value.Id},
					});
				}

				_selected = value;
				OnPropertyChanged("Selected");
			}
		}

		public bool InProgress
		{
			get
			{
				return _inProgress;
			}

			set
			{
				if (value.Equals(_inProgress))
				{
					return;
				}

				_inProgress = value;
				OnPropertyChanged("InProgress");
			}
		}

		#endregion

		#region Methods

		protected override async Task LoadAsync(IDictionary<string, object> parameters)
		{
			try
			{
				InProgress = true;

				// reset the list everytime we load the page
				StockItems.Clear();

				var stockItems = await _stocklistRepository.GetAllStockItems();

				// for all contracts build stock item view model and add to the observable collection
				foreach (var model in stockItems.Select(x =>
					{
						var model = _stockItemFactory();
						model.Apply(x);
						return model;
					}))
				{
					StockItems.Add(model);
				}

				InProgress = false;
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e);
			}
		}

		#endregion

		#region Constructors

		public StocklistPageViewModel(INavigationService navigation, IStocklistRepository stocklistRepository,
			Func<StockItemViewModel> stockItemFactory) : base(navigation)
		{
			_stockItemFactory = stockItemFactory;

			_stocklistRepository = stocklistRepository;

			StockItems = new ObservableCollection<StockItemViewModel>();
		}

		#endregion
	}
}