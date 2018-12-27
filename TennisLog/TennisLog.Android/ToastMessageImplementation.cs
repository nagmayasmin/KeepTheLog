using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(TennisLog.Droid.ToastMessageImplementation))]

namespace TennisLog.Droid
{
    public class ToastMessageImplementation : PageRenderer, Helpers.IMessage
    {
        public void ShortTimeToast(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Short).Show();
        }
    }
}