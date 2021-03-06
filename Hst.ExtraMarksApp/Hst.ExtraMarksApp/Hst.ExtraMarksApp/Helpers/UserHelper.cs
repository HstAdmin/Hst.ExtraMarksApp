
using Hst.ExtraMarksApp;
using Hst.ExtraMarksApp.Models.User;
using Hst.ExtraMarksApp.Views.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Hst.ExtraMarksApp.Helpers
{
    public class UserHelper
    {
        public static string UserImagePath { get; set; }= App.GetPropertyValue("UserImagePath"); 
        public static string UserName { get { return App.GetPropertyValue("UserName"); } }

        public static int UserId
        {
            get
            {
                //return 1;
                var userId = Convert.ToString(App.GetPropertyValue("UserId"));
                if (string.IsNullOrEmpty(userId))
                    return 0;
                else
                    return Convert.ToInt32(userId);
            }
        }
        public static int UserType
        {
            get
            {
                //return 1;
                var userType = Convert.ToString(App.GetPropertyValue("UserType"));
                if (string.IsNullOrEmpty(userType))
                    return 0;
                else
                    return Convert.ToInt32(userType);
            }
        }
        public static int ParentsId
        {
            get
            {
                //return 1;
                var parentsId = Convert.ToString(App.GetPropertyValue("ParentsId"));
                if (string.IsNullOrEmpty(parentsId))
                    return 0;
                else
                    return Convert.ToInt32(parentsId);
            }
        }
        public static bool IsLoggedIn
        {
            get
            {
                if (UserId == 0)
                    return false;
                return true;
            }
        }

        public static void Login(UserModel loginResponse)
        {
            if (loginResponse != null)
            {
                App.SetPropertyValue("IsJustLoggedIn", "1");

                App.SetPropertyValue("MobileApiToken", loginResponse.AccessToken);
                App.SetPropertyValue("MobileApiRefreshToken", loginResponse.RefreshToken);
                App.SetPropertyValue("UserName", loginResponse.FirstName);
                App.SetPropertyValue("UserId", loginResponse.Id);
                App.SetPropertyValue("UserType", loginResponse.UserTypeId);

                App.NavigationPage = new NavigationPage(new MainPage());
                App.Current.MainPage = App.NavigationPage;
            }

        }
        public static void Logout()
        {
            App.SetPropertyValue("IsJustLoggedIn", "1");
            App.SetPropertyValue("SBMS.MobileApiToken", "");
            App.SetPropertyValue("CustomerName", string.Empty);
            App.SetPropertyValue("CustomerId", 0);

            App.SetPropertyValue("CustomerModel", "");

            App.NavigationPage = new NavigationPage(new Login());
            App.Current.MainPage = App.NavigationPage;

        }
       
    }
}
