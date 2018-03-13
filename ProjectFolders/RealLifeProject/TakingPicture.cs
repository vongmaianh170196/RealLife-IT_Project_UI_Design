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

namespace RealLifeProject
{
    [Activity(Label = "TakingPicture")]
    public class TakingPicture : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TakingPicture);

            Button camerabtn = FindViewById<Button>(Resource.Id.camerabtn);
            Button nextbtn = FindViewById<Button>(Resource.Id.nextbtn_arrow);
            ImageView img = FindViewById<ImageView>(Resource.Id.img_taken);
          
            
        }
    }
}