using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace XamAndroidAlertasDialog
{
    [Activity(Label = "XamAndroidAlertasDialog", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

        public override void OnBackPressed()
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetMessage("Desea Salir de la Aplicacion?");
            builder.SetTitle("Salir");
            builder.SetPositiveButton("Si",PositiveButton);
            builder.SetNegativeButton("No", NegativeButton);
            //base.OnBackPressed();
            AlertDialog dialog = builder.Create();
            dialog.Show();
        }

        private void NegativeButton(object sender, DialogClickEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void PositiveButton(object sender, DialogClickEventArgs e)
        {
            // throw new NotImplementedException();
            Finish();
        }
    }
}

