using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjektSM2.Models;

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
        }
    }
}