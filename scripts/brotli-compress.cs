using System;
using System.IO;
using System.IO.Compression;

var files = new[] {
    @"C:\work\prtask.com\publish\web\wwwroot\index.html",
    @"C:\work\prtask.com\publish\web\wwwroot\service-worker.published.js",
    @"C:\work\prtask.com\publish\web\wwwroot\PrTask.Client.styles.css",
    @"C:\work\prtask.com\publish\web\wwwroot\_content\PrTask.SharedUI\css\app.min.css",
    @"C:\work\prtask.com\publish\web\wwwroot\_content\PrTask.SharedUI\PrTask.SharedUI.58anj8sw7j.bundle.scp.css"
};

foreach (var file in files)
{
    if (!File.Exists(file)) { Console.WriteLine($"SKIP: {file}"); continue; }
    var bytes = File.ReadAllBytes(file);
    var brFile = file + ".br";
    using (var fs = File.Create(brFile))
    using (var br = new BrotliStream(fs, CompressionLevel.Optimal))
    {
        br.Write(bytes, 0, bytes.Length);
    }
    Console.WriteLine($"{Path.GetFileName(file)}.br: {new FileInfo(brFile).Length} bytes (from {bytes.Length})");
}
