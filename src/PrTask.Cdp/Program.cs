using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var Builder = WebAssemblyHostBuilder.CreateDefault(args);
Builder.RootComponents.Add<PrTask.Claude.Wasm.App>("#app");
await Builder.Build().RunAsync();
