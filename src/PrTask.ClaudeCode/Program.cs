using System.Text.Json;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PrTask.ClaudeCode.Services;

var Builder = WebAssemblyHostBuilder.CreateDefault(args);
Builder.RootComponents.Add<PrTask.ClaudeCode.App>("#app");
Builder.Services.AddScoped(Sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });
await Builder.Build().RunAsync();
