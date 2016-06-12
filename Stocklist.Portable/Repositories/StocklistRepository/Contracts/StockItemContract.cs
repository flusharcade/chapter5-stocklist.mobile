// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewportContract.cs" company="Health Connex">
//   Copyright (c) 2015 Health Connex All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.Repositories.GeocodingRepository.Contracts
{
	using System.Collections.Generic;

    /// <summary>
    /// Viewport contract.
    /// </summary>
	public sealed class StockItemContract
    {
        #region Public Properties

		public int Id { get; set;}

		public string Name { get; set; }

		public string Category { get; set; }

		public decimal Price { get; set; }

        #endregion
    }
}
