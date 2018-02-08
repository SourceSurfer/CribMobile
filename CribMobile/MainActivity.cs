using Android.App;
using Android.OS;
using Android.Widget;
using CsharpKeyWords;
using Android.Support.V7.App;
using Android.Views;


namespace CribMobile
{
    [Activity(Label = "C# Key Words", MainLauncher = true, Icon = "@drawable/Icon" , Theme="@style/MyTheme")]
	public class MainActivity : AppCompatActivity
   {
		

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
            
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
		}


        [Java.Interop.Export("button_Click")]
        public void button_Click(View view)
        {
            var btn = view as Button;
            switch (btn.Text)
            {
                case "KeyWords":
                    StartActivity(typeof(Keywords));
                    break;
                case "Operators":
                    StartActivity(typeof(Operators));
                    break;
                case "Preprocessor":
                    StartActivity(typeof(Preprocessor));
                    break;
                default:break;
            }
		}
    }
}