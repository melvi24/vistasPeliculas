using Android.App;
using Android.OS;
using VistaPeliculas.Droid;

[Activity(
        Theme = "@style/Theme.Splash",
        MainLauncher = true,
        NoHistory = true)]


public class splashActivity : Activity
{
    protected override void OnCreate(Bundle bundle)
    {
        base.OnCreate(bundle);
        // Set our view from the "main" layout resource
        System.Threading.Thread.Sleep(1800);
        this.StartActivity(typeof(MainActivity));
    }
}



