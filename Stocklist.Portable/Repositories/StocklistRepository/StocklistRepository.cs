// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StocklistRepository.cs" company="Health Connex">
//   Copyright (c) 2015 Health Connex All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Portable.Repositories.StocklistRepository
{
	using System;
	using System.Linq;
	using System.Net;
	using System.Net.Http;
	using System.Reactive.Linq;
	using System.Reactive.Subjects;
	using System.Reactive.Threading.Tasks;
	using System.Text;
	using System.Threading.Tasks;
	using System.Collections.Generic;
	using System.Threading;

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;

	using Stocklist.Portable.Repositories.GeocodingRepository.Contracts;
	using Stocklist.Portable.Resources;

	/// <summary>
	/// Geocoding repository.
	/// </summary>
	public sealed class StocklistRepository : IStocklistRepository
	{
		#region Fields

		/// <summary>
		/// The client handler.
		/// </summary>
		private readonly HttpClientHandler clientHandler;

		#endregion

		#region Public Methods and Operators

		/// <summary>
		/// Gets all stock items.
		/// </summary>
		/// <returns>The all stock items.</returns>
		public IObservable<List<StockItemContract>> GetAllStockItems ()
		{
			var authClient = new HttpClient (this.clientHandler);

			var message = new HttpRequestMessage (HttpMethod.Get, new Uri (Config.ApiAllItems));

			return Observable.FromAsync(() => authClient.SendAsync (message, new CancellationToken(false)))
				.SelectMany(async response => 
					{
						if (response.StatusCode != HttpStatusCode.OK)
						{
							throw new Exception("Respone error");
						}

						return await response.Content.ReadAsStringAsync();
					})
				.Select(json => JsonConvert.DeserializeObject<List<StockItemContract>>(json));
		}

		public IObservable<StockItemContract> GetStockItem(int id)
		{
			var authClient = new HttpClient(this.clientHandler);

			var message = new HttpRequestMessage(HttpMethod.Get, new Uri(string.Format(Config.GetStockItem, id)));

			return Observable.FromAsync(() => authClient.SendAsync(message, new CancellationToken(false)))
				.SelectMany(async response =>
					{
						if (response.StatusCode != HttpStatusCode.OK)
						{
							throw new Exception("Respone error");
						}

						return await response.Content.ReadAsStringAsync();
					})
				.Select(json => JsonConvert.DeserializeObject<StockItemContract>(json));
		}

		public async Task DeleteStockItem(int id)
		{
			var authClient = new HttpClient(this.clientHandler);

			await authClient.SendAsync(new HttpRequestMessage(HttpMethod.Post, new Uri(string.Format(Config.DeleteById, id))), new CancellationToken(false));
		}

		#endregion

		#region Constructors and Destructors

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="T:Stocklist.Portable.Repositories.GeocodingRepository.GeocodingRepository"/> class.
		/// </summary>
		/// <param name="clientHandler">Client handler.</param>
		public StocklistRepository(HttpClientHandler clientHandler)
		{
			this.clientHandler = clientHandler;
		}

		#endregion
	}
}
