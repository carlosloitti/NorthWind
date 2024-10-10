

using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Aplicacion started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");