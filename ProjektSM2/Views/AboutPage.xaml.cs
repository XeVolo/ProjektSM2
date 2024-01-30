using Newtonsoft.Json.Linq;
using Plugin.Geolocator;
using System;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektSM2.Views
{
	public partial class AboutPage : ContentPage
	{
		private const string GoogleApiKey = "AIzaSyC6oWZj9kYtylKNcQkGAehpj2VveJx8GIA";
		public AboutPage()
		{
			InitializeComponent();
			GetLocation();
		}
		private async void OnNavigateToWritePageClicked(object sender, EventArgs e)
		{
			
			await Navigation.PushAsync(new WritePage());
		}
		private async void OnNavigateToChoosePageClicked(object sender, EventArgs e)
		{

			await Navigation.PushAsync(new ChoosePage());
		}
		private async void OnNavigateToAddPageClicked(object sender, EventArgs e)
		{

			await Navigation.PushAsync(new NewQuestionPage());
		}
		private async void OnNavigateToItemsPageClicked(object sender, EventArgs e)
		{

			await Navigation.PushAsync(new ItemsPage());
		}
		private async void GetLocation()
		{
			var locator = CrossGeolocator.Current;
			locator.DesiredAccuracy = 50; // Ustaw dokładność lokalizacji (w metrach)

			try
			{
				var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));

				
				string address = await GetAddressFromCoordinates(position.Latitude, position.Longitude);

				LabelLocation.Text = $"Szerokość geo.: {position.Latitude},\n Długość geo.: {position.Longitude}\nAdres: {address}";
			}
			catch (Exception ex)
			{
				
				LabelLocation.Text = $"Unable to get location: {ex.Message}";
			}
		}
		private async Task<string> GetAddressFromCoordinates(double latitude, double longitude)
		{
			using (var client = new HttpClient())
			{
				string apiUrl = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={latitude},{longitude}&key={GoogleApiKey}";

				var response = await client.GetStringAsync(apiUrl);

				// Analiza odpowiedzi JSON
				var jsonObject = JObject.Parse(response);
				var results = jsonObject["results"];
				var firstResult = results?.FirstOrDefault();
				var formattedAddress = firstResult?["formatted_address"]?.ToString();

				return formattedAddress;
			}
		}
	}
}