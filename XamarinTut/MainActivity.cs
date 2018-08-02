using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;

namespace XamarinTut
{
    [Activity(Label = "XamarinTut", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Tutorial Toolbar";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.toolbar_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            string textToShow;

            if (item.ItemId == Resource.Id.menu_info)
                textToShow = "Learn more about us on our website :)";
            else
                textToShow = "Overfloooow";

            Android.Widget.Toast.MakeText(this, item.TitleFormatted + ": " + textToShow,
                Android.Widget.ToastLength.Long).Show();

            return base.OnOptionsItemSelected(item);
        }
    }
}

