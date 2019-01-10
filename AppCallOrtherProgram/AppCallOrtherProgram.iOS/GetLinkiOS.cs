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

[assembly: Xamarin.Forms.Dependency(typeof(GetLinkiOS))]
namespace AppCallOrtherProgram.iOS
{
    public class GetLinkiOS : GetLink
    {
        public string OpenExternalGetLink()
        {
            return "";
        }
    }
}