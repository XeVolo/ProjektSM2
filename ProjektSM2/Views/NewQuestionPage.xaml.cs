using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjektSM2.Models;
using System.IO;

namespace ProjektSM2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewQuestionPage : ContentPage
	{
		public NewQuestionPage()
		{
			InitializeComponent();
		
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(questionEntry.Text))
			{
				await App.Database.SaveWriteAsync(new WriteModel
				{
					Question = questionEntry.Text,
					Answer = ansEntry.Text,
					Incorrectans1 = inAns1Entry.Text,
					Incorrectans2 = inAns2Entry.Text,
					Incorrectans3 = inAns3Entry.Text
				});
				questionEntry.Text = ansEntry.Text = inAns1Entry.Text = inAns2Entry.Text = inAns3Entry.Text = string.Empty;


			}	
			
			string path = "~/danepytanie1.txt";
			string[] lines = File.ReadAllLines(path);
			foreach (var line in lines)
			{
				string[] elements = line.Split(';');
				if (elements.Length == 6)
				{

					int id = Convert.ToInt32(elements[0]);
					string question = elements[1];
					string answer = elements[2];
					string incorrectans1 = elements[3];
					string incorrectans2 = elements[4];
					string incorrectans3 = elements[5];


					await App.Database.SaveWriteAsync(new WriteModel
					{
						Id = id,
						Question = question,
						Answer = answer,
						Incorrectans1 = incorrectans1,
						Incorrectans2 = incorrectans2,
						Incorrectans3 = incorrectans3
					});
				}
			}

		}
	}
}