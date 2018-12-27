using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TennisLog.Helpers;
using TennisLog.Models;
using Xamarin.Forms;

namespace TennisLog.Services
{
    public class SQLitePlayListDatabase : IPlayListService
    {
        readonly SQLiteAsyncConnection database;

        public SQLitePlayListDatabase()
        {
            var dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("Tennislog.db3");
            database = new SQLiteAsyncConnection(dbPath);

          //  database.DropTableAsync<PlayDayTime>().Wait();
            database.CreateTableAsync<PlayDayTime>().Wait();
        }

        public Task<int> SavePlayListAsync(PlayDayTime item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                if (item.PlayDate == DateTime.MinValue)
                {
                    item.PlayDate = DateTime.Now;
                    item.PlayDateString = DateTime.Now.ToShortDateString();
                }
                return database.InsertAsync(item);
            }
        }

        public Task<List<PlayDayTime>> GetPlayListAsync()
        {
            return database.Table<PlayDayTime>().ToListAsync();
        }

        public Task<int> DeleteTodoListAsync(PlayDayTime item)
        {
            return database.DeleteAsync(item);
        }
    }
}
