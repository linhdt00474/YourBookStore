using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourBookStore.Services;
using YourBookStore.Views;

namespace YourBookStore
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
