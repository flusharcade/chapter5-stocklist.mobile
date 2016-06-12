// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INavigationService.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.UI
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Stocklist.Portable.Enums;

	/// <summary>
	/// Navigation service.
	/// </summary>
	public interface INavigationService
	{
		/// <summary>
		/// Navigate the specified pageName and navigationParameters.
		/// </summary>
		/// <param name="pageName">Page name.</param>
		/// <param name="navigationParameters">Navigation parameters.</param>
		Task Navigate (PageNames pageName, IDictionary<string, object> navigationParameters);
	}
}

