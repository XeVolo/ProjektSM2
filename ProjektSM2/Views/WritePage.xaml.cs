using ProjektSM2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektSM2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WritePage : ContentPage
	{
		private List<WriteModel> items = new List<WriteModel>();
		public WritePage()
		{
			InitializeComponent();
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			items = await App.Database.GetWritesAsync();
		}
		private void CheckButtonClick(object sender, EventArgs e)
		{
			if (sender is Button clickedButton)
			{


			}
		}
	}
}