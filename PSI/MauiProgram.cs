﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using PSI.Views;

namespace PSI;

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
			});

        builder.UseMauiCommunityToolkit();

		builder.Services.AddSingleton<MainView>();
		builder.Services.AddTransient<AddLocationView>();

        return builder.Build();
	}
}
