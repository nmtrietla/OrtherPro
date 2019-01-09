using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using AppCallOrtherProgram.Dependency;
using AppCallOrtherProgram.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAppiOS))]
namespace AppCallOrtherProgram.iOS
{
    public class OpenAppiOS : IOpenApp
    {
        public OpenAppiOS() { }

        public void OpenExternalApp()
        {
            NSUrl request = new NSUrl("yourapp://");

            try
            {
                bool isOpened = UIApplication.SharedApplication.OpenUrl(request);

                if (isOpened == false)
                    UIApplication.SharedApplication.OpenUrl(new NSUrl("yourappurl"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Cannot open url: {0}, Error: {1}", request.AbsoluteString, ex.Message);
                var alertView = new UIAlertView("Error", ex.Message, null, "OK", null);

                alertView.Show();
            }
        }
    }
}