using Android.Print;
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
		private int index = 0;
		public WritePage()
		{
			InitializeComponent();
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			items = await App.Database.GetWritesAsync();
			DisplayQuestion();
		}
		private void CheckButtonClick(object sender, EventArgs e)
		{
			string ans = TextBox.Text.ToLower();
			bool correctness = ans.Equals(items[index].Answer.ToLower());
			if (correctness)
			{
				index++;
				if (index >= items.Count - 1) index = 0;
				TextBox.Text = "";
				DisplayAlert("Brawo", "Odpowiedź poprawna", "OK");
				DisplayQuestion();
			}
			else
			{
				TextBox.Text = "";
				DisplayAlert("Niestety", "Odpowiedź błędna", "OK");
			}
		}
		private void DisplayQuestion()
		{
			Question.Text = items[index].Question;
		}
	}
}