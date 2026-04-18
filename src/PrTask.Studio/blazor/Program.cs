     1→using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
     2→
     3→var Builder = WebAssemblyHostBuilder.CreateDefault(args);
     4→Builder.RootComponents.Add<PrTask.Studio.App>(PrTask.Studio.AppConstants.RootSelector);
     5→await Builder.Build().RunAsync();
     6→