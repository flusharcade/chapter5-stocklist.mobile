// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GradientViewRenderer.cs" company="Health Connex">
//   Copyright (c) 2015 Health Connex All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

[assembly: Xamarin.Forms.ExportRenderer(typeof(Stocklist.XamForms.Controls.CustomLabel), typeof(Stocklist.Droid.Renderers.CustomLabel.CustomLabelRenderer))]

namespace Stocklist.Droid.Renderers.CustomLabel
{
	using System;

	using Android.Graphics;

	using Xamarin.Forms;
	using Xamarin.Forms.Platform.Android;

	using Stocklist.XamForms.Controls;

	/// <summary>
	/// Custom label renderer.
	/// </summary>
	public class CustomLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e) 
		{
			base.OnElementChanged (e);

			if (!string.IsNullOrEmpty((e.NewElement as CustomLabel)?.AndroidFontStyle))
			{
				try
				{
					var font = default(Typeface);

					font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, (e.NewElement as CustomLabel)?.AndroidFontStyle + ".ttf");

					if (Control != null)
					{
						Control.Typeface = font;
						Control.TextSize = (float)e.NewElement.FontSize;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
			}
		}
	}
}