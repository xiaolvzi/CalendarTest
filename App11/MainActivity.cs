using Android.App;
using Android.Widget;
using Android.OS;

namespace App11
{
    [Activity(Label = "App11", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            new DatePickerFragment().Show(FragmentManager, "dialog");
        }
    }
}

