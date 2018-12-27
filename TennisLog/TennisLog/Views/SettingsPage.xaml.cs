using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ImageCircle.Forms.Plugin;

namespace TennisLog.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
       public SettingsPage ()
		{
			InitializeComponent ();
                       
		}

        protected override void OnAppearing()
        {
            this.BindingContext = App.ViewModel.CurrentUser;
            base.OnAppearing();
        }
        public void Save_Clicked(object sender, EventArgs args)
        {
            App.ViewModel.CurrentUser.DisplayName = displayName.Text;
        }
	}
}