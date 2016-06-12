﻿// --------------------------------------------------------------------------------------------------
//  <copyright file="XamarinNavigationExtensions.cs" company="Flush Arcade Pty Ltd.">
//    Copyright (c) 2014 Flush Arcade Pty Ltd. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.UI
{
	using System;
	using System.Collections.Generic;

	using Xamarin.Forms;

	using Stocklist.XamForms.Pages;

	using Stocklist.Portable.UI;
	using Stocklist.Portable.Enums;
	using Stocklist.Portable.Ioc;
	using Stocklist.Portable.ViewModels;

	/// <summary>
	/// Xamarin navigation extensions.
	/// </summary>
	public static class XamarinNavigationExtensions
	{
		#region Public Methods and Operators

		/// <summary>
		/// Show the specified page and parameters.
		/// </summary>
		/// <param name="page">Page.</param>
		/// <param name="parameters">Parameters.</param>
		public static void Show(this ContentPage page, IDictionary<string, object> parameters)
		{
			var target = page.BindingContext as ViewModelBase;

			if (target != null)
			{
				target.OnShow(parameters);
			}
		}

		#endregion
	}
}