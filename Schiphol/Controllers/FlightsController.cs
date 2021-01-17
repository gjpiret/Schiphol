using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Schiphol.Models;

namespace Schiphol.Controllers
{
	public class FlightsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		private async Task<string> CallApi(string apiaction, int page = 0)
		{
			using (var client = new HttpClient())
			{
				var url = "https://api.schiphol.nl/public-flights/" + apiaction;
				var app_id = "e227c7da";
				var app_key = "0188c9130d89d05acf91775c4da9d7fa";
				var resourceversion = "v4";

				string qs_page = "page=" + page.ToString();
				url += "?" + qs_page;

				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Add("app_id", app_id);
				client.DefaultRequestHeaders.Add("app_key", app_key);
				client.DefaultRequestHeaders.Add("resourceversion", resourceversion);
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				using (HttpResponseMessage response = await client.GetAsync(url))
				{
					if (response.IsSuccessStatusCode)
					{
						using (HttpContent content = response.Content)
						{
							string result = await content.ReadAsStringAsync();
							return result;
						}
					}
				}
			}

			return string.Empty;
		}

		public async Task<IActionResult> GetFlights(int page = 0)
		{
			string result = await CallApi("flights", page);
			try
			{
				var obj_result = JsonConvert.DeserializeObject<FlightList>(result);
				return PartialView("Flights", obj_result);
			}
			catch (Exception ex)
			{
				return PartialView();
			}
		}

		public async Task<IActionResult> GetAircraftTypes(int page = 0)
		{
			string result = await CallApi("aircrafttypes", page);
			var obj_result = JsonConvert.DeserializeObject<AircraftTypeList>(result);
			return PartialView("AircraftTypes", obj_result);
		}
	}
}
