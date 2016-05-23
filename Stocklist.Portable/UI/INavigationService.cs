// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INavigationService.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.UI
{
	using Stocklist.Portable.Enums;

	public interface INavigationService
	{
		void Navigate (PageNames pageName, IDictionary<string, object> navigationParameters);
	}
}

