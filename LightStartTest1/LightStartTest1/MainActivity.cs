﻿using Android.App;
using Android.Widget;
using Android.OS;
namespace LightStartTest1
{
    [Activity(Label = "LightStartTest1")]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks !", count++);
            };
        }

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }
    }
}

