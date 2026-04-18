using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WillowMaze.Wasm.Services;

var Builder = WebAssemblyHostBuilder.CreateDefault(args);
Builder.RootComponents.Add<WillowMaze.Wasm.App>("#app");
Builder.Services.AddScoped(Sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });
Builder.Services.AddSingleton<INfcWorkbenchService, WssNfcWorkbenchService>();
await Builder.Build().RunAsync();
