using ProjektSM2.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektSM2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoosePage : ContentPage
    {
        List<WriteModel> items = new List<WriteModel>();
        private int index = 0;
        public ChoosePage()
        {
            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            items = await App.Database.GetWritesAsync();

            NewSet();
        }

        private void AnsButtonClick(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {


            }
        }
        private int GetRandom()
        {
            return new Random().Next(0, items.Count);
        }

        private List<int> GetNumbers()
        {
            int count = 4;
            Random rnd = new Random();
            List<int> numbers = new List<int>();

            while (numbers.Count < count)
            {
                int liczba = rnd.Next(0, 3);
                if (!numbers.Contains(liczba))
                {
                    numbers.Add(liczba);
                }
            }

            return numbers;
        }
        private void NewSet()
        {
            index = GetRandom();
            WriteModel currentWrite = items[index];

            Question.Text = currentWrite.Question;

            List<string> choices = new List<string>();
            index = GetRandom();
            choices.Add(items[index].Answer);
            choices.Add(items[index].Incorrectans1);
            choices.Add(items[index].Incorrectans2);
            choices.Add(items[index].Incorrectans3);
            List<int> drawn = GetNumbers();

            Button1.Text = choices[drawn[0]];
            Button2.Text = choices[drawn[1]];
            Button3.Text = choices[drawn[2]];
            Button4.Text = choices[drawn[3]];
        }
    }
}