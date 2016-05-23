﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressComponentContract.cs" company="Health Connex">
//   Copyright (c) 2015 Health Connex All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.Repositories.GeocodingRepository.Contracts
{
	using System.Collections.Generic;

    /// <summary>
    /// Address component contract.
    /// </summary>
	public sealed class AddressComponentContract
    {
        #region Public Properties

		/// <summary>
		/// Gets or sets the long name.
		/// </summary>
		/// <value>The long name.</value>
		public string long_name { get; set; }

		/// <summary>
		/// Gets or sets the short name.
		/// </summary>
		/// <value>The short name.</value>
		public string short_name { get; set; }

		/// <summary>
		/// Gets or sets the types.
		/// </summary>
		/// <value>The types.</value>
		public List<string> types { get; set; }

        #endregion
    }
}
