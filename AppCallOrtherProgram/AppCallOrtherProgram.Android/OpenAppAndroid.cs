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
using AppCallOrtherProgram.Dependency;
using AppCallOrtherProgram.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAppAndroid))]
namespace AppCallOrtherProgram.Droid
{
    [Activity(Label = "OpenAppAndroid")]
    public class OpenAppAndroid : Activity, IOpenApp
    {
        public OpenAppAndroid() { }

        public void OpenExternalApp()
        {
            //String packageName = context.getPackageName();
            //Intent launchIntent = context.getPackageManager().getLaunchIntentForPackage(packageName);
            Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage("com.microsoft.office.officelens");
            //Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage("https://play.google.com/store/apps/details?id=com.microsoft.office.officelens");

            // If not NULL run the app, if not, take the user to the app store
            if (intent != null)
            {
                intent.AddFlags(ActivityFlags.NewTask);
                Forms.Context.StartActivity(intent);
            }
            else
            {
                intent = new Intent(Intent.ActionView);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.SetData(Android.Net.Uri.Parse("market://details?id=com.microsoft.office.officelens"));
                Forms.Context.StartActivity(intent);
            }
        }
    }
}