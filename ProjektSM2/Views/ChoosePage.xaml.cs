using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektSM2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChoosePage : ContentPage
	{
		public ChoosePage()
		{
			InitializeComponent();
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetWritesAsync();
		}
		private void AnsButtonClick(object sender, EventArgs e)
		{
			if (sender is Button clickedButton)
			{
			

			}
		}
	}
}