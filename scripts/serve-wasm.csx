#r "nuget: Microsoft.AspNetCore.App.Ref, 11.0.0-preview.2.25164.2"

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;

var Root = @"C:\work\prtask.com\src\PocketPay.Wasm\bin\Release\net11.0\publish\wwwroot";
var Builder = WebApplication.CreateBuilder();
Builder.WebHost.UseUrls("https://localhost:5000");
var App = Builder.Build();
App.UseStaticFiles(new StaticFileOptions { FileProvider = new PhysicalFileProvider(Root), ServeUnknownFileTypes = true });
App.MapFallbackToFile("index.html", new StaticFileOptions { FileProvider = new PhysicalFileProvider(Root) });
Console.WriteLine("WASM on https://localhost:5000");
App.Run();
