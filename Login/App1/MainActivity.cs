﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Theme = "@android:style/Theme.DeviceDefault.NoActionBar")] //remove title bar
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //email input
            var emailText = FindViewById<EditText>(Resource.Id.email_input);
            //password input
            var passwordText = FindViewById<EditText>(Resource.Id.password_input);
            // Login button
            Button login_button = FindViewById<Button>(Resource.Id.login_btn);

        } 
    }

}

