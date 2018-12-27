using System;
using System.Collections.Generic;
using System.Text;
using TennisLog.Common;
using TennisLog.Models;

namespace TennisLog.ViewModels
{
    public class MainViewModel : ObservableBase
    {
        public MainViewModel()
        {
            this.CurrentUser = new UserInformation()
            {
                DisplayName = "Test",
                BioContent = " Lalla lalla lalla",
                ProfileImageUrl = null
            };
        }


        private UserInformation _currentUser;

        public UserInformation CurrentUser
        {
            get { return this._currentUser; }
            set { this.SetProperty(ref this._currentUser, value); }
        }

        

    }

    
    
}
