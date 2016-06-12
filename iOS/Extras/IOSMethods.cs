﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOSMethods.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.iOS.Extras
{
	using UIKit;

	using Stocklist.Portable.Extras;

	/// <summary>
	/// The methods interface
	/// </summary>
	public class IOSMethods : IMethods
	{
		public void Exit()
		{
			UIApplication.SharedApplication.PerformSelector(new ObjCRuntime.Selector("terminateWithSuccess"), null, 0f);
		}
	}
}

