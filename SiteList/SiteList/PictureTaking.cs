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

namespace SiteList
{
    [Activity(Label = "PictureTaking")]
    public class PictureTaking : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PictureTaking);

            Button camerabtn = FindViewById<Button>(Resource.Id.camerabtn);
            Button nextbtn = FindViewById<Button>(Resource.Id.nextbtn_arrow);
            ImageView img = FindViewById<ImageView>(Resource.Id.img_taken);


            // Create your application here
        }
    }
}