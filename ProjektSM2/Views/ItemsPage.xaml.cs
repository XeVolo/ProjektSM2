﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektSM2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage : ContentPage
	{
		public ItemsPage()
		{
			InitializeComponent();
		}
		
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			collectionView.ItemsSource = await App.Database.GetWritesAsync();
		}
	}
}