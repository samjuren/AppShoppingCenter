using Android.App;
using Android.Runtime;
using AppShoppingCenter.Platforms.Android;

namespace AppShoppingCenter
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership) : base(handle, ownership)
        {
            BorderLessEntryHandler.Init();
        }
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
