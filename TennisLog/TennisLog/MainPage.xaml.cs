using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisLog.Views;
using Xamarin.Forms;

namespace TennisLog
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        protected override void OnAppearing()
        {
            if (App.ViewModel == null)
            {
                App.ViewModel = new ViewModels.MainViewModel();
                App.PlayListViewModel = new ViewModels.AddPlayListViewModel();
                App.ListTennisViewModel = new ViewModels.ListTennisViewModel();
               
            }

            base.OnAppearing();
        }
    }
}
