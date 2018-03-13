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
    [Activity(Label = "SiteList", Theme = "@android:style/Theme.DeviceDefault.NoActionBar")]
    public class SiteList : Activity
    {

        string[] projectitems;
        ListView projectList;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //List of project, this is an example, data will be stored in this array
            projectitems = new string[] {
            "Xamarin",
            "Android",
            "IOS",
            "Windows",
            "Xamarin-Native",
            "Xamarin-Forms"
        };
            // Set our view from the "main" layout resource  
            //Search project function
            //search input
            EditText search_inp = FindViewById<EditText>(Resource.Id.search_input);

            //searh button
            Button search_button = FindViewById<Button>(Resource.Id.search_btn);

            //Layout of ListView ListView.axml
            SetContentView(Resource.Layout.ListView);
            projectList = (ListView)FindViewById<ListView>(Resource.Id.listViewLayout);
            //Displaying of items from Array ProjectListItem.axml
            projectList.Adapter = new ArrayAdapter(this, Resource.Layout.ProjectListItem, Resource.Id.project_list_items, projectitems);
            //Click item
            projectList.ItemClick += ProjectList_ItemClick;
            //Add project button
            Button addProject_button = FindViewById<Button>(Resource.Id.add_btn);
            /*
             * The dialog appears for user to create a new Project
            * */
            addProject_button.Click += delegate {
                LayoutInflater layoutInflater = LayoutInflater.From(this);
                View view = layoutInflater.Inflate(Resource.Layout.newProjectCreate, null);
                Android.App.AlertDialog.Builder createBox = new Android.App.AlertDialog.Builder(this);
                createBox.SetView(view);
                var projectName = view.FindViewById<EditText>(Resource.Id.project_input);
                createBox.SetCancelable(false)
                .SetPositiveButton("CREATE", delegate
                {
                    Toast.MakeText(this, projectName.Text + "is created.", ToastLength.Short).Show();
                })
                .SetNegativeButton("CANCEL", delegate
                {
                    createBox.Dispose();
                });
                Android.App.AlertDialog dialogBox = createBox.Create();
                dialogBox.Show();
            };
        }

        private void ProjectList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //when item folder is clicked, it goes to next page to take picture
            StartActivity(typeof(TakingPicture));
          
        }
    }
}