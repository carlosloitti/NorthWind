﻿

using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Aplicacion started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");