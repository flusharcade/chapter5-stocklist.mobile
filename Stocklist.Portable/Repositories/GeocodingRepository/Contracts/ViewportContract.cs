﻿// --------------------------------------------------------------------------------------------------------------------
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
	public sealed class ViewportContract
    {
        #region Public Properties

		/// <summary>
		/// Gets or sets the northeast.
		/// </summary>
		/// <value>The northeast.</value>
		public NortheastContract northeast { get; set; }

		/// <summary>
		/// Gets or sets the southwest.
		/// </summary>
		/// <value>The southwest.</value>
		public SouthwestContract southwest { get; set; }

        #endregion
    }
}
