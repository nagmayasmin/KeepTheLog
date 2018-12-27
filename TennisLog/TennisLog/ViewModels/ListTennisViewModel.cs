using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TennisLog.Common;
using TennisLog.Models;
using TennisLog.Services;
using Xamarin.Forms;

namespace TennisLog.ViewModels
{
   public class ListTennisViewModel : ObservableBase
    {
        List<PlayDayTime> _playList = new List<PlayDayTime>();
       
        public ListTennisViewModel()
        {
            
            RefreshTodoList = new Command(async () =>
            {
                try
                {
                   App.ListTennisViewModel.PlayList = await DependencyService.Get<IPlayListService>().GetPlayListAsync();
                   Console.WriteLine("Total List of Tennis: " + this.PlayList.Count);
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });

                  
        }

        public List<PlayDayTime> PlayList
        {
            get => _playList;
            set => SetProperty(ref _playList, value);
        }

        public ICommand RefreshTodoList { get; set; }

        

    }
}
