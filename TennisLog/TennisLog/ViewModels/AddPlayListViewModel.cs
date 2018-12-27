using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TennisLog.Common;
using TennisLog.Services;
using TennisLog.Helpers;
using TennisLog.Views;
using Xamarin.Forms;

namespace TennisLog.ViewModels
{
    public class AddPlayListViewModel : ObservableBase
    {
        public AddPlayListViewModel()
        {
            AddPlayList = new Command(async () =>
            {
                /*
                if (String.IsNullOrEmpty(this.Title))
                {
                    return;
                }
                */

                              
                DateTime date = this.PlayDate;
              
                var todoList = await DependencyService.Get<IPlayListService>().SavePlayListAsync(new Models.PlayDayTime()
                {
                    Title = this.Title,

                    PlayDate = this.PlayDate,
                    PlayDateString = date.ToShortDateString(),

                    PlayStartTime = this.PlayStartTime,
                    PlayStartTimeString = PlayStartTime.ToString(),

                    PlayEndTime = this.PlayEndTime,
                    PlayEndTimeString = this.PlayEndTimeString
                });

               
                string msg1 = "Added in the play list";
                DependencyService.Get<IMessage>().ShortTimeToast(msg1);

            });

         //   string msg = "Added in the play list";
          //  DependencyService.Get<IMessage>().ShortTimeToast(msg);
        }
        

        string _title;

        DateTime _playDate;
        string _playDateString;

        TimeSpan _playStartTime;
        string _playStartTimeString;
        
        TimeSpan _playEndTime;
        string _playEndTimeString;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        
        public DateTime PlayDate
        {
            get => _playDate;
            set => SetProperty(ref _playDate, value);
        }


        public string PlayDateString
        {
            get => _playDateString;
            set => SetProperty(ref _playDateString, value);
        }

        public TimeSpan PlayStartTime
        {
            get => _playStartTime;
            set => SetProperty(ref _playStartTime, value);
        }

        public string PlayStartTimeString
        {
            get => _playStartTimeString;
            set => SetProperty(ref _playStartTimeString, value);
        }


        public TimeSpan PlayEndTime
        {
            get => _playEndTime;
            set => SetProperty(ref _playEndTime, value);
        }

        public string PlayEndTimeString
        {
            get => _playEndTimeString;
            set => SetProperty(ref _playEndTimeString, value);
        }
        public ICommand AddPlayList
        {
            get; 
        }
        public ICommand Cancel
        {
            get; 
        }

    }
}
