
using Xamarin.Forms;

namespace relativeview
{
    public class App : Application
    {
        public static Size ScreenSize { get; set; }

        public App()
        {
            // The root page of your application
            MainPage = new RelativePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
