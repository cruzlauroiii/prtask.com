param()

$wwwroot = 'C:\work\prtask.com\publish\web\wwwroot'

# Remove 0-byte .br files (broken ones we just created)
Get-ChildItem $wwwroot -Recurse -Filter '*.br' | Where-Object { $_.Length -eq 0 } | ForEach-Object {
    Write-Host "Removing 0-byte: $($_.FullName)"
    Remove-Item $_.FullName -Force
}

# Use dotnet tool to generate brotli for modified files
$modifiedFiles = @(
    "$wwwroot\index.html",
    "$wwwroot\service-worker.published.js",
    "$wwwroot\PrTask.Client.styles.css",
    "$wwwroot\_content\PrTask.SharedUI\css\app.min.css",
    "$wwwroot\_content\PrTask.SharedUI\PrTask.SharedUI.58anj8sw7j.bundle.scp.css"
)

# Use a .NET 10 inline program to create brotli
$csCode = @'
using System;
using System.IO;
using System.IO.Compression;

class Program {
    static void Main(string[] args) {
        foreach (var file in args) {
            if (!File.Exists(file)) continue;
            var bytes = File.ReadAllBytes(file);
            var brFile = file + ".br";
            using var fs = File.Create(brFile);
            using var br = new BrotliStream(fs, CompressionLevel.Optimal);
            br.Write(bytes, 0, bytes.Length);
            Console.WriteLine($"  {Path.GetFileName(file)}.br: {new FileInfo(brFile).Length} bytes");
        }
    }
}
'@

$csFile = "$env:TEMP\brotli_compress.cs"
$exeFile = "$env:TEMP\brotli_compress.exe"
Set-Content $csFile $csCode

# Use dotnet-script or csc
$cscPath = Get-ChildItem "C:\Program Files\dotnet\sdk" -Recurse -Filter 'csc.dll' | Select-Object -First 1
if ($cscPath) {
    dotnet exec $cscPath.FullName /out:$exeFile $csFile 2>&1 | Out-Null
}

# Alternative: use PowerShell 7+ or just use the .NET runtime directly
# Actually let's just use Add-Type with newer framework
try {
    Add-Type -AssemblyName System.IO.Compression
    # BrotliStream is in System.IO.Compression in .NET Core, not .NET Framework
    # Since we're in Windows PowerShell, we can't use it directly
    # Let's use a C# script via dotnet
} catch {}

# Use dotnet script approach
$scriptContent = @"
var files = new[] {
    @"$($modifiedFiles[0])",
    @"$($modifiedFiles[1])",
    @"$($modifiedFiles[2])",
    @"$($modifiedFiles[3])",
    @"$($modifiedFiles[4])"
};
foreach (var file in files) {
    if (!System.IO.File.Exists(file)) continue;
    var bytes = System.IO.File.ReadAllBytes(file);
    var brFile = file + ".br";
    using var fs = System.IO.File.Create(brFile);
    using var br = new System.IO.Compression.BrotliStream(fs, System.IO.Compression.CompressionLevel.Optimal);
    br.Write(bytes, 0, bytes.Length);
    br.Flush();
    fs.Flush();
    Console.WriteLine(System.IO.Path.GetFileName(file) + ".br: " + new System.IO.FileInfo(brFile).Length + " bytes");
}
"@

$csprojDir = "$env:TEMP\brotli_tool"
if (-not (Test-Path $csprojDir)) { New-Item $csprojDir -ItemType Directory -Force | Out-Null }

Set-Content "$csprojDir\Program.cs" $scriptContent
Set-Content "$csprojDir\brotli_tool.csproj" @"
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
  </PropertyGroup>
</Project>
"@

Write-Host "Generating .br files..."
dotnet run --project $csprojDir 2>&1

Write-Host "Done."
