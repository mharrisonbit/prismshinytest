using System;
using Android.App;
using Android.Runtime;

namespace PrismShinyTest.Droid
{
    [Application]
    public class MainApplication : ShinyAndroidApplication<ShinyAppStartup>
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }
    }
}