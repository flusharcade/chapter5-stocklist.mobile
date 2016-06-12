// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGeocodingRepository.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.Repositories.StocklistRepository
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Stocklist.Portable.Repositories.GeocodingRepository.Contracts;

	/// <summary>
	/// The stock item repository interface.
	/// </summary>
	public interface IStocklistRepository
	{
		#region Methods and Operators

		/// <summary>
		/// Gets the stock items.
		/// </summary>
		/// <returns>The stock items.</returns>
		IObservable<List<StockItemContract>> GetAllStockItems ();

		/// <summary>
		/// Gets the stock item.
		/// </summary>
		/// <returns>The stock item.</returns>
		/// <param name="id">Identifier.</param>
		IObservable<StockItemContract> GetStockItem(int id);

		/// <summary>
		/// Deletes the item by identifier.
		/// </summary>
		/// <returns>The item by identifier.</returns>
		/// <param name="id">Identifier.</param>
		Task DeleteStockItem(int id);

		#endregion
	}
}
