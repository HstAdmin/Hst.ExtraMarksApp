using Autofac;
using Hst.ExtraMarksApp.Helpers;
using Hst.ExtraMarksApp.Services;
using Hst.ExtraMarksApp.Views;
using Hst.ExtraMarksApp.Views.User;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hst.ExtraMarksApp
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; set; }
        public static IContainer Container;
        public App()
        {

            InitializeComponent();
            Bootstrapper.Initialize();            
            XF.Material.Forms.Material.Init(this);
            
            NavigationPage = new NavigationPage(new Login());
            MainPage = NavigationPage;

            //IPageService pageService = new PageService();
            //pageService.ShowSuccess(Convert.ToString(UserHelper.CustomerId));
            //if (!UserHelper.IsLoggedIn)
            //{
            //    NavigationPage = new NavigationPage(new Login());
            //    MainPage = NavigationPage;
            //}
            //else
            //{
            //    NavigationPage = new NavigationPage(new MainPage());
            //    MainPage = NavigationPage;
            //}            
        }

        protected override void OnStart()
        {
            SetPropertyValue("MobileApiBaseURL", "http://schoolapi.shoppingchale.com/");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        public static dynamic GetPropertyValue(string propName)
        {
            //Preferences.Set("my_key", "my_value");
            if (Application.Current.Properties.ContainsKey(propName))
                return Application.Current.Properties[propName];
            return "";
        }
        public static void SetPropertyValue(string propName, dynamic value)
        {
            Application.Current.Properties[propName] = value;
            Application.Current.SavePropertiesAsync();
        }
    }
}
