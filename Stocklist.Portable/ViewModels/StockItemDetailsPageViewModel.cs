// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StocklistPageViewModel.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.ViewModels
{
	using System;
	using System.Reactive.Subjects;
	using System.Reactive.Linq;
	using System.Linq;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Collections.ObjectModel;
	using System.Windows.Input;

	using Stocklist.Portable.UI;
	using Stocklist.Portable.Repositories.StocklistRepository;

	/// <summary>
	/// Stocklist page view model.
	/// </summary>
	public class StockItemDetailsPageViewModel : ViewModelBase
	{
		#region Subjects

		#endregion

		#region Private Properties

		private readonly IStocklistRepository _stocklistRepository;

		private int _id;

		private string _name;

		private string _category;

		private decimal _price;

		private bool _inProgress;

		private ICommand _deleteCommand;

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id
		{
			get
			{
				return _id;
			}

			set
			{
				if (value.Equals(_id))
				{
					return;
				}

				_id = value;
				OnPropertyChanged("Id");
			}
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get
			{
				return _name;
			}

			set
			{
				if (value.Equals(_name))
				{
					return;
				}

				_name = value;
				OnPropertyChanged("Name");
			}
		}

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public string Category
		{
			get
			{
				return _category;
			}

			set
			{
				if (value.Equals(_category))
				{
					return;
				}

				_category = value;
				OnPropertyChanged("Category");
			}
		}

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public decimal Price
		{
			get
			{
				return _price;
			}

			set
			{
				if (value.Equals(_price))
				{
					return;
				}

				_price = value;
				OnPropertyChanged("Price");
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

		public ICommand _priceteCommand
		{
			get
			{
				return _deleteCommand;
			}

			set
			{
				if (value.Equals(_deleteCommand))
				{
					return;
				}

				_deleteCommand = value;
				OnPropertyChanged("DeleteCommand");
			}
		}

		#endregion

		#region Methods

		protected override async Task LoadAsync(IDictionary<string, object> parameters)
		{
			InProgress = true;

			if (parameters.ContainsKey("id"))
			{
				Id = (int)parameters["id"];
			}

			var contract = await _stocklistRepository.GetStockItem(Id);

			if (contract != null)
			{
				this.Name = contract.Name;
				this.Category = contract.Category;
				this.Price = contract.Price;
			}

			InProgress = false;
		}

		#endregion

		#region Constructors

		public StockItemDetailsPageViewModel(INavigationService navigation, IStocklistRepository stocklistRepository,
			Func<Action, ICommand> commandFactory) : base(navigation)
		{
			_stocklistRepository = stocklistRepository;

			_deleteCommand = commandFactory(() =>
			{
				_stocklistRepository.DeleteStockItem(Id);
			});
		}

		#endregion
	}
}