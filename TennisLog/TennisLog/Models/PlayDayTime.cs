using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TennisLog.Models
{
      public class PlayDayTime
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(64)]
            public string Title { get; set; }

            public DateTime PlayDate { get; set; }
            public string PlayDateString { get; set; }

            public TimeSpan PlayStartTime { get; set; }
            public string PlayStartTimeString { get; set; }

            public TimeSpan PlayEndTime { get; set; }
            public string PlayEndTimeString { get; set; }

    }
}

