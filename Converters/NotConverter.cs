// --------------------------------------------------------------------------------------------------
//  <copyright file="NotConverter.cs" company="Health Connex">
//    Copyright (c) 2015 Health Connex All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Converters
{
	using System;

	using Xamarin.Forms;

	/// <summary>
	/// Not converter.
	/// </summary>
	public class NotConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			var b = value as bool?;

			if (b != null)
			{
				return !b;
			}

			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}