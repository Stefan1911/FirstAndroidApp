using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            TextView txtNumber = FindViewById<TextView>(Resource.Id.numberTxt);

            FindViewById<Button>(Resource.Id.changeBt).Click += (o, e) =>
            {
                int number = int.Parse(txtNumber.Text);
                txtNumber.Text = (++number).ToString();
            };

            
        }
    }
}

