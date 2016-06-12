// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomLabel.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.XamForms.Controls
{
	using Xamarin.Forms;

	/// <summary>
	/// Custom label.
	/// </summary>
	public class CustomLabel : Label
	{
		/// <summary>
		/// The android font style property.
		/// </summary>
		public static readonly BindableProperty AndroidFontStyleProperty = BindableProperty.Create<CustomLabel, string>(
			p => p.AndroidFontStyle, default(string));

		/// <summary>
		/// Gets or sets the android font style.
		/// </summary>
		/// <value>The android font style.</value>
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