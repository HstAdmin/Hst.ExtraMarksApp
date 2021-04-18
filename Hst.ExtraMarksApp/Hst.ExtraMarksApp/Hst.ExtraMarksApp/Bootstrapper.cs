

using Autofac;
using Hst.ExtraMarksApp.Services;
using Hst.ExtraMarksApp.Services.User;
using Hst.ExtraMarksApp.ViewModels;
using Hst.ExtraMarksApp.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;


namespace Hst.ExtraMarksApp
{
    public static class Bootstrapper
    {
        public static IPageService PageService { get { return App.Container.Resolve<IPageService>(); } }

        public static void Initialize()
        {
            if (App.Container == null)
            {
                var builder = new ContainerBuilder();
                //builder.RegisterType<PageService>().As<IPageService>().SingleInstance();
                builder.RegisterType<PageService>().As<IPageService>();
                builder.RegisterType<UserService>().As<IUserService>();
                //builder.RegisterType<LocalCacheService>().As<ICacheService>();
                //builder.RegisterType<CommonService>().As<ICommonService>();
                //builder.RegisterType<StudentService>().As<IStudentService>();
                //builder.RegisterType<OrderService>().As<IOrderService>();

                //
                //builder.RegisterType<HomePageViewModel>().AsSelf();
                builder.RegisterType<LoginViewModel>().AsSelf();
                //builder.RegisterType<RegisterViewModel>().AsSelf();
          
                //builder.RegisterType<ChangePasswordViewModel>().AsSelf();
                //builder.RegisterType<ProfileViewModel>().AsSelf();
                //builder.RegisterType<StudentViewModel>().AsSelf();
                //builder.RegisterType<BuyBookViewModel>().AsSelf();
                //builder.RegisterType<AddEditStudentViewModel>().AsSelf();
                //builder.RegisterType<ViewOrderViewModel>().AsSelf();
                //builder.RegisterType<OrdersViewModel>().AsSelf();
                //builder.RegisterType<BookSellerHomePageViewModel>().AsSelf();
                //builder.RegisterType<ParentsRegistrationViewModel>().AsSelf();
                //builder.RegisterType<ParentsProfileViewModel>().AsSelf();
                

                App.Container = builder.Build();

            }
        }
    }
}
