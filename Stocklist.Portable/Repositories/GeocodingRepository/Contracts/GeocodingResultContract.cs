﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeocodingResultContract.cs" company="Health Connex">
//   Copyright (c) 2015 Health Connex All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.Repositories.GeocodingRepository.Contracts
{
	using System.Collections.Generic;

    /// <summary>
    /// Geocoding result contract.
    /// </summary>
	public sealed class GeocodingResultContract
    {
        #region Public Properties

		/// <summary>
		/// Gets or sets the address components.
		/// </summary>
		/// <value>The address components.</value>
		public List<AddressComponentContract> address_components { get; set; }

		/// <summary>
		/// Gets or sets the formatted address.
		/// </summary>
		/// <value>The formatted address.</value>
		public string formatted_address { get; set; }

		/// <summary>
		/// Gets or sets the geometry.
		/// </summary>
		/// <value>The geometry.</value>
		public GeometryContract geometry { get; set; }

		/// <summary>
		/// Gets or sets the place identifier.
		/// </summary>
		/// <value>The place identifier.</value>
		public string place_id { get; set; }

		/// <summary>
		/// Gets or sets the types.
		/// </summary>
		/// <value>The types.</value>
		public List<string> types { get; set; }

        #endregion
    }
}
