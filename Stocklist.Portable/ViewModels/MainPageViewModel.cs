// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPageViewModel.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.ViewModels
{
	using System;
	using System.Windows.Input;

	using Stocklist.Portable.Enums;
	using Stocklist.Portable.UI;
	using Stocklist.Portable.Extras;

	public class MainPageViewModel : ViewModelBase
	{
		#region Private Properties

		private bool _inProgress;

		private ICommand _stocklistCommand;

		private ICommand _exitCommand;

		#endregion

		#region Public Properties

		public bool InProgress
		{
			get
			{
				return _inProgress;
			}

			set
			{
				if (value.Equals(_inProgress))
				{
					return;
				}

				_inProgress = value;
				OnPropertyChanged("InProgress");
			}
		}

		public ICommand StocklistCommand
		{
			get
			{
				return _stocklistCommand;
			}

			set
			{
				if (value.Equals(_stocklistCommand))
				{
					return;
				}

				_stocklistCommand = value;
				OnPropertyChanged("StocklistCommand");
			}
		}

		public ICommand ExitCommand
		{
			get
			{
				return _exitCommand;
			}

			set
			{
				if (value.Equals(_exitCommand))
				{
					return;
				}

				_exitCommand = value;
				OnPropertyChanged("ExitCommand");
			}
		}

		#endregion

		#region Constructors

		public MainPageViewModel (INavigationService navigation, Func<Action, ICommand> commandFactory,
			IMethods methods) : base (navigation)
		{
			_exitCommand = commandFactory (() =>
			{
				methods.Exit();
			});

			_stocklistCommand = commandFactory (() =>
			{
				Navigation.Navigate(PageNames.StocklistPage, null);
			});
		}

		#endregion
	}
}

