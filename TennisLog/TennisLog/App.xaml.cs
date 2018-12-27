using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TennisLog.Services;
using Xamarin.Forms;

namespace TennisLog
{
	public partial class App : Application
	{
      public static ViewModels.AddPlayListViewModel PlayListViewModel { get; set; }
      public static ViewModels.ListTennisViewModel ListTennisViewModel { get; set; }
      public static ViewModels.MainViewModel ViewModel { get; set; }

        public App ()
		{
			InitializeComponent();

            DependencyService.Register<SQLitePlayListDatabase>();

            MainPage = new NavigationPage(new TennisLog.MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
