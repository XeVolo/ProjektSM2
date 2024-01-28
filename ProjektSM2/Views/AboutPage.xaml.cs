using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektSM2.Views
{
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
		}
		private async void OnNavigateToWritePageClicked(object sender, EventArgs e)
		{
			
			await Navigation.PushAsync(new WritePage());
		}
		private async void OnNavigateToChoosePageClicked(object sender, EventArgs e)
		{

			await Navigation.PushAsync(new ChoosePage());
		}
	}
}