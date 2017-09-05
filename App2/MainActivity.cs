using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Este es un comentario para ver si hay algun cambio pendiente
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

