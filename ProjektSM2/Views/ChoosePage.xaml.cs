using ProjektSM2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektSM2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChoosePage : ContentPage
	{
		private List<WriteModel> items = new List<WriteModel>();
		public ChoosePage()
		{
			InitializeComponent();
			
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
            items = await App.Database.GetWritesAsync();

			Question.Text = items.First().Question;
			Button1.Text = items.First().Answer;
		}
		private void AnsButtonClick(object sender, EventArgs e)
		{
			if (sender is Button clickedButton)
			{


			}
		}
	}
}