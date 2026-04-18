using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var Builder = WebAssemblyHostBuilder.CreateDefault(args);
Builder.RootComponents.Add<WillowMaze.Wasm.App>("#app");
Builder.Services.AddScoped(Sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });
await Builder.Build().RunAsync();
