using System;
using System.Collections.Generic;
using System.IO;
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
using AppCallOrtherProgram.iOS;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(GetLinkAndroid))]
namespace AppCallOrtherProgram.iOS
{
    public class GetLinkAndroid : GetLink
    {
        public string OpenExternalGetLink()
        {
            //var filename = "db.db3";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments );

            //var path = Path.Combine(documentspath, filename);
            Java.IO.File directory = new Java.IO.File(documentspath + Java.IO.File.Separator + "Office Lens");
            Java.IO.File[] files = directory.ListFiles();
            string kq = "";
            foreach (var i in files)
            {
                FileInfo info = new FileInfo(i.Name);
                kq = kq + info.Name+";";
                //if (info.Name.Contains("Wall_e"))
                //{
                //    di.Add(new DownloadedImages { Path1 = info.DirectoryName, Name1 = info.FullName });
                //}
            }
            return "";
        }
    }
}
//string phyle;
//string ffilelist = "";
//public void listfiles()
//{
//    try
//    {
//        var path1 = "/storage/emulated/0/Music/";
//        var mp3Files = Directory.EnumerateFiles(path1, "*.mp3", SearchOption.AllDirectories);
//        foreach (string currentFile in mp3Files)
//        {
//            phyle = currentFile;
//            ffilelist = ffilelist + "\n" + phyle;
//        }
//        //playpath(phyle); // play the last file found
//    }
//    catch (Exception e9)
//    {
//        Toast.MakeText(ApplicationContext, "ut oh\n" + e9.Message, ToastLength.Long).Show();
//    }
//}