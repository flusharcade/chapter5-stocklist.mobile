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

		private int id;

		private string name;

		private string category;

		private decimal price;

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
				return this.id;
			}

			set
			{
				if (value.Equals(this.id))
				{
					return;
				}

				this.id = value;
				this.OnPropertyChanged("Id");
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
				return this.name;
			}

			set
			{
				if (value.Equals(this.name))
				{
					return;
				}

				this.name = value;
				this.OnPropertyChanged("Name");
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
				return this.category;
			}

			set
			{
				if (value.Equals(this.category))
				{
					return;
				}

				this.category = value;
				this.OnPropertyChanged("Category");
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
				return this.price;
			}

			set
			{
				if (value.Equals(this.price))
				{
					return;
				}

				this.price = value;
				this.OnPropertyChanged("Price");
			}
		}

		#endregion

		#region Public Methods

		public void Apply(StockItemContract contract)
		{
			this.Id = contract.Id;
			this.Name = contract.Name;
			this.Category = contract.Category;
			this.Price = contract.Price;
		}

		#endregion

		#region Constructors

		public StockItemViewModel (INavigationService navigation) : base (navigation)
		{
		}

		#endregion
	}
}

