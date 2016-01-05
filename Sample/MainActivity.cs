using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using CN.Jeesoft.Widget.Pickerview;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity, CharacterPickerView.IOnOptionChangedListener
    {
        int count = 1;
        private RelativeLayout.LayoutParams layoutParams;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
        private void ShowView()
        {
            //懒得写了,代码在java文件夹
        }

        public void OnOptionChanged(CharacterPickerView p0, int p1, int p2, int p3)
        {
          
        }


    }
}

