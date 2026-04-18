var WwwRootPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "src", "PrTask.Client", "bin", "Release", "net10.0", "wwwroot"));
var Builder = WebApplication.CreateBuilder(new WebApplicationOptions { WebRootPath = WwwRootPath });
Builder.WebHost.UseUrls("https://0.0.0.0:0");
var App = Builder.Build();
App.Use(async (Context, Next) =>
{
    var ReqPath = Context.Request.Path.Value ?? string.Empty;
    if (!string.IsNullOrEmpty(ReqPath) && !System.IO.Path.HasExtension(ReqPath))
    {
        var TrimmedPath = ReqPath.TrimStart('/').TrimEnd('/');
        if (TrimmedPath.Length > 0)
        {
            var IndexFilePath = System.IO.Path.Combine(App.Environment.WebRootPath, TrimmedPath.Replace('/', System.IO.Path.DirectorySeparatorChar), "index.html");
            if (System.IO.File.Exists(IndexFilePath))
            {
                Context.Response.ContentType = "text/html";
                await Context.Response.SendFileAsync(IndexFilePath);
                return;
            }
            var HtmlFilePath = System.IO.Path.Combine(App.Environment.WebRootPath, (TrimmedPath + ".html").Replace('/', System.IO.Path.DirectorySeparatorChar));
            if (System.IO.File.Exists(HtmlFilePath))
            {
                Context.Response.ContentType = "text/html";
                await Context.Response.SendFileAsync(HtmlFilePath);
                return;
            }
        }
    }
    await Next();
});
App.UseStaticFiles();
App.MapFallbackToFile("index.html");
App.Lifetime.ApplicationStarted.Register(() =>
{
    var Addresses = App.Urls;
    foreach (var Address in Addresses)
    {
        Console.WriteLine($"SERVING_ON: {Address}");
    }
});
App.Run();
