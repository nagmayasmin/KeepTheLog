using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TennisLog.Models;
using TennisLog.Services;
using TennisLog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTennisPage : ContentPage
    {
        public ListTennisPage()
        {
            InitializeComponent();
           
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
          //  App.ListTennisViewModel.RefreshTodoList.Execute(null);

            MyListView.ItemsSource =  await DependencyService.Get<IPlayListService>().GetPlayListAsync();

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
