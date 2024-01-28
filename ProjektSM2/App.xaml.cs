using ProjektSM2.Models;
using ProjektSM2.Services;
using System;
using System.IO;
using Xamarin.Forms;

namespace ProjektSM2
{
    public partial class App : Application
	{
		private static Database database;
		public static Database Database
		{
			get
			{
				if(database == null)
				{
					database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3"));
				}
				return database;
			}
		}
		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
