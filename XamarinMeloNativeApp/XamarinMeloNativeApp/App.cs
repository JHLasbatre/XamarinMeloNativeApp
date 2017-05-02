#if __ANDROID__
using XamarinMeloNativeApp.Droid;
#elif __IOS__
using XamarinMeloNativeApp.iOS.Helpers;
#elif WINDOWS_UWP
using XamarinMeloNativeApp.UWP.Helpers;
#endif
using XamarinMeloNativeApp.Helpers;
using XamarinMeloNativeApp.Interfaces;
using XamarinMeloNativeApp.Services;
using XamarinMeloNativeApp.Model;

namespace XamarinMeloNativeApp
{
    public partial class App 
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            ServiceLocator.Instance.Register<IMessageDialog, MessageDialog>();
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}