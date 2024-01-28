using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
		private void AnsButtonClick(object sender, EventArgs e)
		{
			if (sender is Button clickedButton)
			{
			

			}
		}
	}
}