// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomLabel.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Controls
{
	using Xamarin.Forms;

	public class CustomLabel : Label
	{
		public static readonly BindableProperty AndroidFontStyleAndroidFontStyleProperty = BindableProperty.Create<CustomLabel, string>(
			p => p.AndroidFontStyle, default(string));

		public string AndroidFontStyle
		{
			get
			{
				return (string)GetValue(AndroidFontStyleProperty);
			}
			set
			{
				SetValue(AndroidFontStyleProperty, value);
			}
		}
	}
}