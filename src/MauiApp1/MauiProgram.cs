﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using MauiApp1.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureContainer(new AutofacServiceProviderFactory(), (autofac) =>
                {
                    autofac.RegisterType<MainPage>().SingleInstance();
                    autofac.RegisterType<MainPageViewModel>().SingleInstance();
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IMauiInitializeService>(new IocConfigurationService());

            return builder.Build();
        }
    }
}