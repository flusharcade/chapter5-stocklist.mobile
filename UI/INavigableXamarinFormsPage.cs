﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationService.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.UI
{
	using System.Collections.Generic;

	/// <summary>
	/// Navigable xamarin forms page.
	/// </summary>
	internal interface INavigableXamarinFormsPage
	{
		#region Methods

		/// <summary>
		/// Called when navigated to
		/// </summary>
		/// <returns>The navigated to.</returns>
		/// <param name="navigationParameters">Navigation parameters.</param>
		void OnNavigatedTo(IDictionary<string, object> navigationParameters);

		#endregion
	}
}