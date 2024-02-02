using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;

namespace AppShoppingCenter.Platforms.Android
{
    public class BorderLessEntryHandler
    {
        public static void Init()
        {
            EntryHandler
                .Mapper
                .AppendToMapping("EntryBorderless", SetBorderLess);
        }

        private static void SetBorderLess(IEntryHandler handler, IEntry view) 
        {
            handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToAndroid());
        }
    }
}
