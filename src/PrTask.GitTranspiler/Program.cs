using System.Globalization;
using PrTask.GitTranspiler;
using PrTask.GitTranspiler;

var GitSourceDir = args.Length > 0 ? args[0] : @"C:\work\git";
var OutputDir = args.Length > 1 ? args[1] : @"C:\work\prtask.com\src\PrTask.Git\Generated";

if (!Directory.Exists(GitSourceDir))
{
    Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture, "Git source not found: {0}", GitSourceDir));
    return 1;
}

Directory.CreateDirectory(OutputDir);

var Converter = new CToSharpConverter(GitSourceDir, OutputDir);
var ConvertedCount = Converter.ConvertAll();

Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Transpiled {0} C files to C# in {1}", ConvertedCount, OutputDir));
return 0;
