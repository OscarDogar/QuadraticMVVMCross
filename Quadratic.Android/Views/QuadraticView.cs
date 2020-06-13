
using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using Quadratic.Core.ViewModels;

namespace Quadratic.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class QuadraticView : MvxActivity<QuadraticViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.QuadraticPage);
        }
    }
}