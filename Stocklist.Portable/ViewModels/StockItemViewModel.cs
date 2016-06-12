// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPageViewModel.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.ViewModels
{
	using Stocklist.Portable.Enums;
	using Stocklist.Portable.UI;
	using Stocklist.Portable.Extras;

	using Stocklist.Portable.Repositories.GeocodingRepository.Contracts;

	public class StockItemViewModel : ViewModelBase
	{
		#region Private Properties

		private int _id;

		private string _name;

		private string _category;

		private decimal _price;

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

		#endregion

		#region Public Methods

		public void Apply(StockItemContract contract)
		{
			Id = contract.Id;
			Name = contract.Name;
			Category = contract.Category;
			Price = contract.Price;
		}

		#endregion

		#region Constructors

		public StockItemViewModel (INavigationService navigation) : base (navigation)
		{
		}

		#endregion
	}
}

