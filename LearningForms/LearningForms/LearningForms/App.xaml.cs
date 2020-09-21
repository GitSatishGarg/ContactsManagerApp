using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningForms
{
    public partial class App : Application
    {
        public static string FilePath;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage());
        }
        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage());
            FilePath = filePath;
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
