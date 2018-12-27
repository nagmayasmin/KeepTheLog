using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace TennisLog.Models
{
    public class PlayListInformation :   ObservableCollection<PlayDayTime>
    {
        public async Task AddAsync(PlayDayTime playDayTime)
        {
            var playList = new PlayDayTime()
            {
                Title = playDayTime.Title 
            };

           // await 
        }

    }
}
