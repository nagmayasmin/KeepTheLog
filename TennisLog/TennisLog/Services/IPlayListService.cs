using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TennisLog.Models;

namespace TennisLog.Services
{
   public interface IPlayListService
    {
        Task<List<PlayDayTime>> GetPlayListAsync();
        Task<int> SavePlayListAsync(PlayDayTime item);

      //  Task<int> DeletePlayListAsync(PlayDayTime item);
        
    }
}
