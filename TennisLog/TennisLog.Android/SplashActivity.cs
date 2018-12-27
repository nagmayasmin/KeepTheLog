using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TennisLog.Droid
{
    [Activity(Label = "TennisLog", Theme ="@style/Theme.Splash", MainLauncher =true, NoHistory =true)]
    public class SplashActivity : Activity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);

        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startUpWork = new Task(async () =>
            {
                await Task.Delay(400);
            });

            startUpWork.ContinueWith(t =>
            {
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            }, TaskScheduler.FromCurrentSynchronizationContext());

            startUpWork.Start();
        }
    }
}