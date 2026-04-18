#r "nuget: System.Reflection.Metadata, 9.0.3"
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

var DllPath = @"C:\work\dotnet\sdk\artifacts\bin\redist\Release\dotnet\packs\Microsoft.Android.Ref.36\36.1.99-preview.1.119\ref\net11.0\Mono.Android.dll";
var Fs = File.OpenRead(DllPath);
var Pe = new PEReader(Fs);
var Reader = Pe.GetMetadataReader();

foreach (var Th in Reader.TypeDefinitions)
{
    var Td = Reader.GetTypeDefinition(Th);
    var Name = Reader.GetString(Td.Name);
    if (Name.Contains("Screenshot"))
    {
        var Ns = Reader.GetString(Td.Namespace);
        Console.WriteLine($"{Ns}.{Name}");
    }
}
