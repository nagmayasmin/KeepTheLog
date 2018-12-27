using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisLog.Helpers;
using TennisLog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisLog.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataEntryPage : ContentPage
	{
       public DataEntryPage ()
		{
			InitializeComponent ();
         
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string msg = "This is a Longtime toast";
            DependencyService.Get<IMessage>().ShortTimeToast(msg);
        }


    }
}