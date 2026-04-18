using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Text;
using PrTask.Domain.Constants;

namespace PrTask.Transpiler;

public sealed class DexToBlazorConverter
{
    private readonly string ApkPath;
    private readonly string OutputDir;
    private readonly string Namespace;
    private readonly string AppTitle;

    public DexToBlazorConverter(string ApkPath, string OutputDir, string Namespace, string AppTitle)
    {
        this.ApkPath = ApkPath;
        this.OutputDir = OutputDir;
        this.Namespace = Namespace;
        this.AppTitle = AppTitle;
    }

    public ApkConversionResult Convert()
    {
        var Result = new ApkConversionResult();

        try
        {
            using var Archive = ZipFile.OpenRead(ApkPath);

            Directory.CreateDirectory(OutputDir);
            Directory.CreateDirectory(Path.Combine(OutputDir, "wwwroot"));
            Directory.CreateDirectory(Path.Combine(OutputDir, "wwwroot", "css"));
            Directory.CreateDirectory(Path.Combine(OutputDir, "Pages"));
            Directory.CreateDirectory(Path.Combine(OutputDir, "Layout"));
            Directory.CreateDirectory(Path.Combine(OutputDir, "Services"));
            Directory.CreateDirectory(Path.Combine(OutputDir, "Models"));
            Directory.CreateDirectory(Path.Combine(OutputDir, "Decompiled"));

            var AllClasses = new List<DexClassDef>();
            var DexCount = 0;
            var TotalMethods = 0;

            foreach (var Entry in Archive.Entries)
            {
                if (!Entry.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                using var Stream = Entry.Open();
                using var Ms = new MemoryStream();
                Stream.CopyTo(Ms);
                var DexBytes = Ms.ToArray();

                var Parser = new DexParser(DexBytes);
                if (!Parser.Parse())
                {
                    continue;
                }

                DexCount++;
                AllClasses.AddRange(Parser.ClassDefs);
                TotalMethods += Parser.MethodIdsSize;
                Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
                    "  DEX: {0} ({1} bytes, {2} classes, {3} methods, {4} strings)",
                    Entry.FullName, DexBytes.Length, Parser.ClassDefsSize, Parser.MethodIdsSize, Parser.StringIdsSize));
            }

            var WwwrootCount = ExtractApkAssets(Archive, OutputDir);
            Result.WwwrootAssetCount = WwwrootCount;

            var AppClasses = AllClasses
                .Where(C => !C.IsSystem)
                .OrderBy(C => C.Package, StringComparer.Ordinal)
                .ThenBy(C => C.ClassName, StringComparer.Ordinal)
                .ToList();

            Result.TypeCount = AppClasses.Count;
            Result.AssemblyCount = DexCount;

            Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
                "  Total: {0} DEX files, {1} app classes ({2} total), {3} method IDs, {4} assets",
                DexCount, AppClasses.Count, AllClasses.Count, TotalMethods, WwwrootCount));

            GenerateBlazorProject(AppClasses);
            GenerateDecompiledSources(AppClasses);

            var JadxCount = RunJadxDecompilation();
            if (JadxCount > 0)
            {
                Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
                    "  jadx: {0} Java files converted to C#", JadxCount));
            }

            var LayoutConverter = new AndroidLayoutConverter();
            LayoutConverter.LoadFromApk(ApkPath);
            LayoutConverter.GeneratePages(OutputDir, Namespace);

            var ProxyGen = new WssProxyGenerator(OutputDir, Namespace);
            ProxyGen.Generate(AppClasses);

            Result.Success = true;
        }
        catch (InvalidDataException)
        {
            Console.Error.WriteLine("File is not a valid APK/ZIP archive");
        }

        return Result;
    }

    private static int ExtractApkAssets(ZipArchive Archive, string OutputDir)
    {
        var Count = 0;
        var AssetsDir = Path.Combine(OutputDir, "wwwroot", "assets");

        foreach (var Entry in Archive.Entries)
        {
            if (!Entry.FullName.StartsWith("assets/", StringComparison.Ordinal) ||
                Entry.FullName.EndsWith("/", StringComparison.Ordinal) ||
                Entry.Length == 0)
            {
                continue;
            }

            var RelPath = Entry.FullName["assets/".Length..].Replace('/', Path.DirectorySeparatorChar);
            var TargetPath = Path.Combine(AssetsDir, RelPath);
            var TargetDir = Path.GetDirectoryName(TargetPath);
            if (TargetDir is not null)
            {
                Directory.CreateDirectory(TargetDir);
            }

            Entry.ExtractToFile(TargetPath, overwrite: true);
            Count++;
        }

        return Count;
    }

    private void GenerateBlazorProject(List<DexClassDef> AppClasses)
    {
        WriteCsproj();
        WriteProgram();
        WriteImports();
        WriteAppRazor();
        WriteMainLayout();
        WriteIndexHtml();
        WriteCss();
        WriteHomePage(AppClasses);
    }

    private void GenerateDecompiledSources(List<DexClassDef> AppClasses)
    {
        var Count = 0;
        var MethodCount = 0;
        var WithBodies = 0;

        foreach (var Cls in AppClasses)
        {
            if (Cls.ClassName.Length == 0)
            {
                continue;
            }

            try
            {

            var SafeName = Cls.ClassName.Replace('$', '_').Replace('-', '_');
            var PkgDir = Cls.Package.Length > 0 ? Cls.Package.Replace('.', Path.DirectorySeparatorChar) : "_default";
            var Category = Cls.IsEnum ? "Enums" : Cls.IsInterface ? "Contracts" : "Types";
            var SubDir = Path.Combine(OutputDir, "Decompiled", Category, PkgDir);
            Directory.CreateDirectory(SubDir);

            var Sb = new StringBuilder();
            Sb.Append("namespace ").Append(Namespace).Append(".Decompiled").AppendLine(";");
            Sb.AppendLine();

            if (Cls.IsEnum)
            {
                Sb.Append("public enum ").AppendLine(ToPascalCase(SafeName));
                Sb.AppendLine("{");
                foreach (var F in Cls.Fields.Where(F => F.IsStatic && F.IsFinal))
                {
                    Sb.Append("    ").Append(ToPascalCase(F.Name)).AppendLine(",");
                }

                Sb.AppendLine("}");
            }
            else if (Cls.IsInterface)
            {
                Sb.Append("public interface ").AppendLine(ToPascalCase(SafeName));
                Sb.AppendLine("{");
                var Seen = new HashSet<string>(StringComparer.Ordinal);
                foreach (var M in Cls.Methods.Where(M => M.Name != "<init>" && M.Name != "<clinit>"))
                {
                    var Sig = BuildMethodSignature(M);
                    if (!Seen.Add(Sig))
                    {
                        continue;
                    }

                    var RetType = DexParser.MapJavaType(M.Proto.ReturnType);
                    Sb.Append("    ").Append(RetType).Append(' ').Append(ToPascalCase(M.Name)).Append('(');
                    WriteMethodParams(Sb, M.Proto.ParamTypes);
                    Sb.AppendLine(");");
                }

                Sb.AppendLine("}");
            }
            else
            {
                var Modifier = Cls.IsAbstract ? "public abstract class " : "public class ";
                Sb.Append(Modifier).Append(ToPascalCase(SafeName));

                var BaseType = DexParser.MapJavaType(Cls.SuperClass);
                if (BaseType.Length > 0 && BaseType != "object" && BaseType != "Object" && BaseType != "Enum" && BaseType != "Exception")
                {
                    Sb.Append(" : ").Append(ToPascalCase(BaseType));
                }

                if (Cls.Interfaces.Count > 0)
                {
                    var Prefix = BaseType.Length > 0 && BaseType != "object" ? ", " : " : ";
                    var Ifaces = Cls.Interfaces.Select(I => ToPascalCase(DexParser.MapJavaType(I))).Distinct();
                    Sb.Append(Prefix).Append(string.Join(", ", Ifaces));
                }

                Sb.AppendLine();
                Sb.AppendLine("{");

                foreach (var F in Cls.Fields)
                {
                    var FType = DexParser.MapJavaType(F.TypeName);
                    Sb.Append("    ");
                    Sb.Append(F.IsPublic ? "public " : "private ");
                    if (F.IsStatic)
                    {
                        Sb.Append("static ");
                    }

                    if (F.IsFinal && !F.IsStatic)
                    {
                        Sb.Append("readonly ");
                    }

                    Sb.Append(FType).Append(' ').Append(ToPascalCase(F.Name)).AppendLine(";");
                }

                if (Cls.Fields.Count > 0 && Cls.Methods.Count > 0)
                {
                    Sb.AppendLine();
                }

                var MethodSeen = new HashSet<string>(StringComparer.Ordinal);
                foreach (var M in Cls.Methods.Where(M => M.Name != "<init>" && M.Name != "<clinit>"))
                {
                    var Sig = BuildMethodSignature(M);
                    if (!MethodSeen.Add(Sig))
                    {
                        continue;
                    }

                    MethodCount++;
                    var RetType = DexParser.MapJavaType(M.Proto.ReturnType);
                    Sb.Append("    ");
                    Sb.Append(M.IsPublic ? "public " : "private ");
                    if (M.IsStatic)
                    {
                        Sb.Append("static ");
                    }

                    Sb.Append(RetType).Append(' ').Append(ToPascalCase(M.Name)).Append('(');
                    WriteMethodParams(Sb, M.Proto.ParamTypes);
                    Sb.AppendLine(")");
                    Sb.AppendLine("    {");

                    if (M.DecompiledBody.Length > 0)
                    {
                        foreach (var Line in M.DecompiledBody.Split('\n'))
                        {
                            if (Line.Trim().Length > 0)
                            {
                                Sb.Append("        ").AppendLine(Line.TrimEnd());
                            }
                        }

                        WithBodies++;
                    }

                    WriteDefaultReturn(Sb, RetType);
                    Sb.AppendLine("    }");
                    Sb.AppendLine();
                }

                Sb.AppendLine("}");
            }

            var FileName = ToPascalCase(SafeName) + ".cs";
            File.WriteAllText(Path.Combine(SubDir, FileName), Sb.ToString());
            Count++;
            }
            catch
            {
            }
        }

        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Decompiled {0} classes, {1} methods ({2} with IL annotations)", Count, MethodCount, WithBodies));
    }

    private static string BuildMethodSignature(DexMethodDef M)
    {
        var Sb = new StringBuilder();
        Sb.Append(M.IsStatic ? "s:" : "i:");
        Sb.Append(DexParser.MapJavaType(M.Proto.ReturnType));
        Sb.Append(' ');
        Sb.Append(M.Name);
        Sb.Append('(');
        for (var I = 0; I < M.Proto.ParamTypes.Count; I++)
        {
            if (I > 0)
            {
                Sb.Append(',');
            }

            Sb.Append(DexParser.MapJavaType(M.Proto.ParamTypes[I]));
        }

        Sb.Append(')');
        return Sb.ToString();
    }

    private static void WriteMethodParams(StringBuilder Sb, List<string> ParamTypes)
    {
        for (var I = 0; I < ParamTypes.Count; I++)
        {
            if (I > 0)
            {
                Sb.Append(", ");
            }

            var PType = DexParser.MapJavaType(ParamTypes[I]);
            Sb.Append(PType).Append(" P").Append(I);
        }
    }

    private static void WriteDefaultReturn(StringBuilder Sb, string RetType)
    {
        if (RetType == "void")
        {
            return;
        }

        Sb.Append("        return ");
        Sb.Append(RetType switch
        {
            "bool" => "false",
            "int" or "long" or "short" or "byte" or "float" or "double" or "decimal" => "0",
            "string" => "string.Empty",
            "Task" => "Task.CompletedTask",
            _ when RetType.StartsWith("Task<", StringComparison.Ordinal) => "Task.FromResult<object>(null!)",
            _ => "default!"
        });
        Sb.AppendLine(";");
    }

    private void WriteHomePage(List<DexClassDef> AppClasses)
    {
        var Packages = AppClasses
            .GroupBy(C => C.Package)
            .OrderByDescending(G => G.Count())
            .Take(30)
            .ToList();

        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/\"");
        Sb.AppendLine();
        Sb.Append("<h1>").Append(AppTitle).AppendLine(" - Transpiled</h1>");
        Sb.AppendLine("<p>Transpiled from compiled Android APK (DEX bytecode) to .NET 11 Blazor WebAssembly.</p>");
        Sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
            "<div class=\"card\"><h2>Summary</h2><p>{0} packages, {1} classes, {2} methods, {3} fields</p></div>",
            Packages.Count, AppClasses.Count,
            AppClasses.Sum(C => C.Methods.Count),
            AppClasses.Sum(C => C.Fields.Count)));
        Sb.AppendLine("<div class=\"grid\">");

        foreach (var Pkg in Packages)
        {
            Sb.AppendLine("    <div class=\"card\">");
            Sb.Append("        <h2>").Append(Pkg.Key.Length > 0 ? Pkg.Key : "(default)").AppendLine("</h2>");
            Sb.Append("        <p>").Append(Pkg.Count()).AppendLine(" classes</p>");
            foreach (var Cls in Pkg.Take(10))
            {
                Sb.Append("        <span class=\"badge\">").Append(Cls.ClassName).AppendLine("</span>");
            }

            if (Pkg.Skip(10).Any())
            {
                Sb.Append("        <span class=\"badge\">+").Append(Pkg.Count() - 10).AppendLine(" more</span>");
            }

            Sb.AppendLine("    </div>");
        }

        Sb.AppendLine("</div>");
        File.WriteAllText(Path.Combine(OutputDir, "Pages", "Index.razor"), Sb.ToString());
    }

    private void WriteCsproj()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk.BlazorWebAssembly\">");
        Sb.AppendLine("  <PropertyGroup>");
        Sb.AppendLine("    <TargetFramework>net11.0</TargetFramework>");
        Sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        Sb.AppendLine("    <Nullable>enable</Nullable>");
        Sb.Append("    <RootNamespace>").Append(Namespace).AppendLine("</RootNamespace>");
        Sb.Append("    <NoWarn>").Append(ApkConstants.NoWarnList).AppendLine("</NoWarn>");
        Sb.AppendLine("    <EnableTrimAnalyzer>false</EnableTrimAnalyzer>");
        Sb.AppendLine("  </PropertyGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <Compile Remove=\"Decompiled/**/*.cs\" />");
        Sb.AppendLine("    <None Include=\"Decompiled/**/*.cs\" />");
        Sb.Append("    <Compile Remove=\"").Append(Namespace).AppendLine(".Backoffice/**/*.cs\" />");
        Sb.Append("    <None Include=\"").Append(Namespace).AppendLine(".Backoffice/**/*.cs\" />");
        Sb.Append("    <Compile Remove=\"").Append(Namespace).AppendLine(".Companion/**/*.cs\" />");
        Sb.Append("    <None Include=\"").Append(Namespace).AppendLine(".Companion/**/*.cs\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <PackageReference Include=\"Microsoft.AspNetCore.Components.WebAssembly\" Version=\"11.0.0-preview.2.26159.112\" />");
        Sb.AppendLine("    <PackageReference Include=\"Microsoft.AspNetCore.Components.WebAssembly.DevServer\" Version=\"11.0.0-preview.2.26159.112\" PrivateAssets=\"all\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("</Project>");
        File.WriteAllText(Path.Combine(OutputDir, Namespace + ".csproj"), Sb.ToString());
    }

    private void WriteProgram()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using System.Net.Http.Json;");
        Sb.AppendLine("using Microsoft.AspNetCore.Components.WebAssembly.Hosting;");
        Sb.AppendLine("var Builder = WebAssemblyHostBuilder.CreateDefault(args);");
        Sb.Append("Builder.RootComponents.Add<").Append(Namespace).AppendLine(".App>(\"#app\");");
        Sb.AppendLine("Builder.Services.AddScoped(Sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });");
        Sb.AppendLine("await Builder.Build().RunAsync();");
        File.WriteAllText(Path.Combine(OutputDir, "Program.cs"), Sb.ToString());
    }

    private void WriteImports()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@using System.Globalization");
        Sb.AppendLine("@using System.Net.Http.Json");
        Sb.AppendLine("@using Microsoft.AspNetCore.Components");
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Web");
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Routing");
        Sb.Append("@using ").AppendLine(Namespace);
        Sb.Append("@using ").Append(Namespace).AppendLine(".Pages");
        Sb.Append("@using ").Append(Namespace).AppendLine(".Layout");
        File.WriteAllText(Path.Combine(OutputDir, "_Imports.razor"), Sb.ToString());
    }

    private void WriteAppRazor()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Router AppAssembly=\"typeof(Program).Assembly\">");
        Sb.AppendLine("    <Found Context=\"routeData\">");
        Sb.AppendLine("        <RouteView RouteData=\"routeData\" DefaultLayout=\"typeof(Layout.MainLayout)\" />");
        Sb.AppendLine("    </Found>");
        Sb.AppendLine("    <NotFound>");
        Sb.AppendLine("        <LayoutView Layout=\"typeof(Layout.MainLayout)\"><p>Not found</p></LayoutView>");
        Sb.AppendLine("    </NotFound>");
        Sb.AppendLine("</Router>");
        File.WriteAllText(Path.Combine(OutputDir, "App.razor"), Sb.ToString());
    }

    private void WriteMainLayout()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Layout", "MainLayout.razor"),
            "@inherits LayoutComponentBase\n\n<div class=\"layout-frame\">\n    <NavMenu />\n    @Body\n</div>\n");
    }

    private void WriteIndexHtml()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<!DOCTYPE html><html lang=\"en\"><head>");
        Sb.AppendLine("<meta charset=\"utf-8\" /><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />");
        Sb.Append("<title>").Append(AppTitle).AppendLine("</title><base href=\"/\" /><link rel=\"icon\" href=\"data:,\" />");
        Sb.AppendLine("<link rel=\"stylesheet\" href=\"css/app.css\" />");
        Sb.AppendLine("<!-- No scoped CSS -->");
        Sb.AppendLine("</head><body>");
        Sb.Append("<div id=\"app\">Loading ").Append(AppTitle).AppendLine("...</div>");
        Sb.AppendLine("<script src=\"_framework/blazor.webassembly.js\"></script>");
        Sb.AppendLine("</body></html>");
        File.WriteAllText(Path.Combine(OutputDir, "wwwroot", "index.html"), Sb.ToString());
    }

    private void WriteCss()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine(":root{--bg:#0f1722;--surface:#172334;--border:#223247;--mint:#8cffd7;--text:#edf6ff;--muted:#a6bbcf}");
        Sb.AppendLine("html,body{margin:0;padding:0;background:var(--bg);color:var(--text);font-family:system-ui,sans-serif}");
        Sb.AppendLine(".layout-frame{max-width:72rem;margin:0 auto;padding:1.5rem;min-height:100vh}");
        Sb.AppendLine("h1,h2{color:var(--mint)} .card{background:var(--surface);border:1px solid var(--border);border-radius:12px;padding:1.25rem;margin-bottom:1rem}");
        Sb.AppendLine(".grid{display:grid;grid-template-columns:repeat(auto-fit,minmax(20rem,1fr));gap:.75rem}");
        Sb.AppendLine(".badge{background:var(--border);color:var(--muted);padding:.2rem .6rem;border-radius:6px;font-size:.8rem;display:inline-block;margin:.15rem}");
        Sb.AppendLine(".app-shell{max-width:72rem;margin:0 auto}");
        Sb.AppendLine(".app-header{text-align:center;padding:2rem 0 1rem;border-bottom:1px solid var(--border);margin-bottom:1.5rem}");
        Sb.AppendLine(".app-header h1{font-size:2rem;margin:0}");
        Sb.AppendLine(".app-header p{color:var(--muted);margin:.5rem 0 0}");
        Sb.AppendLine(".screen-grid{display:grid;grid-template-columns:repeat(auto-fit,minmax(14rem,1fr));gap:.75rem}");
        Sb.AppendLine(".screen-card{background:var(--surface);border:1px solid var(--border);border-radius:12px;padding:1.25rem;text-decoration:none;color:var(--text);transition:border-color .15s}");
        Sb.AppendLine(".screen-card:hover{border-color:var(--mint)}");
        Sb.AppendLine(".screen-card h2{color:var(--mint);font-size:1rem;margin:0 0 .25rem}");
        Sb.AppendLine(".screen-card p{color:var(--muted);font-size:.8rem;margin:0}");
        Sb.AppendLine(".screen-card.small{padding:.6rem .8rem;font-size:.85rem}");
        Sb.AppendLine(".all-screens{margin-top:1.5rem}");
        Sb.AppendLine(".all-screens summary{color:var(--mint);cursor:pointer;padding:.5rem 0}");
        Sb.AppendLine(".nav-menu{display:flex;flex-wrap:wrap;gap:.5rem;padding:.75rem 0;margin-bottom:1rem;border-bottom:1px solid var(--border)}");
        Sb.AppendLine(".nav-menu a{color:var(--muted);text-decoration:none;padding:.3rem .75rem;border-radius:6px;font-size:.85rem;background:var(--surface)}");
        Sb.AppendLine(".nav-menu a:hover{color:var(--mint);background:var(--border)}");
        Sb.AppendLine("header{background:var(--surface);padding:.75rem 1rem;border-radius:8px;margin-bottom:.75rem}");
        Sb.AppendLine("button{background:var(--mint);color:var(--bg);border:none;padding:.6rem 1.25rem;border-radius:8px;font-weight:600;cursor:pointer;margin:.25rem}");
        Sb.AppendLine("button:hover{filter:brightness(1.1)}");
        Sb.AppendLine("input,select{background:var(--bg);color:var(--text);border:1px solid var(--border);padding:.5rem .75rem;border-radius:6px;width:100%;box-sizing:border-box;margin:.25rem 0}");
        Sb.AppendLine("label{display:flex;flex-direction:column;gap:.25rem;color:var(--muted);font-size:.85rem;margin-bottom:.5rem}");
        Sb.AppendLine("span{display:inline-block}");
        Sb.AppendLine("progress{width:100%;height:4px;border-radius:2px}");
        Sb.AppendLine("nav{background:var(--surface);border-radius:8px;padding:.5rem}");
        Sb.AppendLine("img{max-width:100%;height:auto}");
        Sb.AppendLine(".login-form{max-width:24rem;margin:2rem auto;display:flex;flex-direction:column;gap:1rem}");
        Sb.AppendLine(".login-form input{font-size:1.1rem;padding:.75rem 1rem}");
        Sb.AppendLine(".login-form button{font-size:1.1rem;padding:.75rem 1.5rem;width:100%}");
        Sb.AppendLine(".login-form .error{color:#ff6b6b;font-size:.85rem;margin:0}");
        Sb.AppendLine(".login-form h2{text-align:center;margin:0 0 .5rem}");
        Sb.AppendLine(".login-form p{text-align:center;color:var(--muted);margin:0}");
        Sb.AppendLine(".login-form input[type=password]{font-size:1.1rem;padding:.75rem 1rem;letter-spacing:.1rem}");
        Sb.AppendLine(".otp-input{letter-spacing:.5rem;text-align:center;font-size:1.5rem!important}");
        Sb.AppendLine(".pin-dots{display:flex;justify-content:center;gap:.75rem;margin:1rem 0}");
        Sb.AppendLine(".pin-dot{width:1rem;height:1rem;border-radius:50%;border:2px solid var(--border);background:transparent;transition:background .15s}");
        Sb.AppendLine(".pin-dot.filled{background:var(--mint);border-color:var(--mint)}");
        Sb.AppendLine(".numpad{display:grid;grid-template-columns:repeat(3,1fr);gap:.5rem;max-width:18rem;margin:0 auto}");
        Sb.AppendLine(".numpad button{font-size:1.5rem;padding:1rem;background:var(--surface);color:var(--text);border:1px solid var(--border)}");
        Sb.AppendLine(".numpad button:hover{background:var(--border)}");
        Sb.AppendLine(".splash-screen{display:flex;flex-direction:column;align-items:center;justify-content:center;min-height:80vh}");
        Sb.AppendLine(".splash-screen h1{font-size:3rem;margin-bottom:1rem}");
        Sb.AppendLine(".splash-screen p{color:var(--muted);font-size:1.2rem}");
        Sb.AppendLine(".dashboard-grid{display:grid;grid-template-columns:repeat(auto-fit,minmax(10rem,1fr));gap:1rem;margin-top:1.5rem}");
        Sb.AppendLine(".dashboard-tile{background:var(--surface);border:1px solid var(--border);border-radius:12px;padding:1.5rem;text-align:center;text-decoration:none;color:var(--text)}");
        Sb.AppendLine(".dashboard-tile:hover{border-color:var(--mint)}");
        Sb.AppendLine(".dashboard-tile h3{color:var(--mint);margin:0 0 .25rem}");
        Sb.AppendLine(".dashboard-header{text-align:center;padding:2rem 0 1rem;border-bottom:1px solid var(--border);margin-bottom:1.5rem}");
        Sb.AppendLine(".dashboard-header h1{font-size:2rem;margin:0;color:var(--mint)}");
        Sb.AppendLine(".dashboard-header p{color:var(--muted);margin:.5rem 0 0;font-size:1.1rem}");
        Sb.AppendLine(".stats-card{background:var(--surface);border:1px solid var(--border);border-radius:12px;padding:1.25rem;margin-bottom:1rem}");
        Sb.AppendLine(".stats-card h3{color:var(--mint);margin:0 0 .5rem}");
        Sb.AppendLine(".stats-card p{margin:.25rem 0;color:var(--text)}");
        Sb.AppendLine(".quick-actions{display:grid;grid-template-columns:repeat(3,1fr);gap:1rem;margin:1.5rem 0}");
        Sb.AppendLine(".quick-action-card{background:var(--surface);border:1px solid var(--border);border-radius:12px;padding:1.5rem;text-align:center;text-decoration:none;color:var(--text);transition:border-color .15s,transform .1s}");
        Sb.AppendLine(".quick-action-card:hover{border-color:var(--mint);transform:translateY(-2px)}");
        Sb.AppendLine(".quick-action-card h3{font-size:2rem;margin:0 0 .5rem}");
        Sb.AppendLine(".quick-action-card span{font-size:.9rem;font-weight:600}");
        Sb.AppendLine(".product-preview{background:var(--surface);border:1px solid var(--border);border-radius:12px;padding:1.25rem;margin-bottom:1rem}");
        Sb.AppendLine(".product-preview h3{color:var(--mint);margin:0 0 .75rem}");
        Sb.AppendLine(".product-preview-item{display:flex;justify-content:space-between;padding:.4rem 0;border-bottom:1px solid var(--border)}");
        Sb.AppendLine(".product-preview-item:last-child{border-bottom:none}");
        Sb.AppendLine(".device-status{display:flex;align-items:center;gap:.5rem;padding:.75rem 1rem;background:var(--surface);border:1px solid var(--border);border-radius:8px;margin-top:1rem;font-size:.9rem}");
        Sb.AppendLine(".device-status-dot{width:10px;height:10px;border-radius:50%;flex-shrink:0}");
        Sb.AppendLine(".device-status-dot.online{background:#4ade80}");
        Sb.AppendLine(".device-status-dot.offline{background:#f87171}");
        Sb.AppendLine(".inline-login{min-height:80vh;display:flex;align-items:center;justify-content:center}");
        Sb.AppendLine("@media(max-width:40rem){.quick-actions{grid-template-columns:repeat(2,1fr)}}");
        File.WriteAllText(Path.Combine(OutputDir, "wwwroot", "css", "app.css"), Sb.ToString());
    }

    private int RunJadxDecompilation()
    {
        var JadxPath = ResolveJadxPath();
        if (JadxPath.Length == 0)
        {
            Console.WriteLine("  jadx: not found, using stub decompilation only");
            return 0;
        }

        var TempDir = Path.Combine(OutputDir, "jadx-temp");
        var ApkDir = Path.GetDirectoryName(ApkPath) ?? ".";
        var PreExistingJadx = Path.Combine(ApkDir, "jadx-merged", "sources");
        if (!Directory.Exists(PreExistingJadx))
        {
            PreExistingJadx = Path.Combine(ApkDir, "jadx-output", "sources");
        }

        try
        {
            string SourcesDir;

            if (Directory.Exists(PreExistingJadx))
            {
                Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
                    "  jadx: reusing pre-existing output at {0}", PreExistingJadx));
                SourcesDir = PreExistingJadx;
            }
            else
            {
                Directory.CreateDirectory(TempDir);

                var Psi = new ProcessStartInfo
                {
                    FileName = JadxPath,
                    Arguments = string.Format(CultureInfo.InvariantCulture,
                        "--show-bad-code --no-res --no-imports --no-inline-anonymous --no-inline-methods --no-move-inner-classes --no-inline-kotlin-lambda --no-finally --no-restore-switch-over-string --no-replace-consts --respect-bytecode-access-modifiers --no-debug-info --comments-level error --threads-count 16 -d \"{0}\" \"{1}\"", TempDir, ApkPath),
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };

                using var Proc = Process.Start(Psi);
                if (Proc is null)
                {
                    Console.Error.WriteLine("  jadx: failed to start process");
                    return 0;
                }

                Proc.WaitForExit(TimeSpan.FromMinutes(30));
                if (!Proc.HasExited)
                {
                    Proc.Kill();
                    Console.Error.WriteLine("  jadx: timed out after 30 minutes");
                    return 0;
                }

                SourcesDir = Path.Combine(TempDir, "sources");
                if (!Directory.Exists(SourcesDir))
                {
                    Console.Error.WriteLine("  jadx: no sources directory produced");
                    return 0;
                }
            }

            var Converter = new JavaToCSharpConverter(Namespace);
            var Count = 0;

            foreach (var JavaFile in Directory.EnumerateFiles(SourcesDir, "*.java", SearchOption.AllDirectories))
            {
                try
                {
                    var JavaSource = File.ReadAllText(JavaFile);
                    var CSharpSource = Converter.Convert(JavaSource);

                    var RelPath = Path.GetRelativePath(SourcesDir, JavaFile);
                    var CsPath = Path.ChangeExtension(RelPath, ".cs");
                    var TargetPath = Path.Combine(OutputDir, "Decompiled", CsPath);
                    var TargetDir = Path.GetDirectoryName(TargetPath);
                    if (TargetDir is not null)
                    {
                        Directory.CreateDirectory(TargetDir);
                    }

                    File.WriteAllText(TargetPath, CSharpSource);
                    Count++;
                }
                catch
                {
                }
            }

            return Count;
        }
        catch (Exception Ex)
        {
            Console.Error.WriteLine(string.Format(CultureInfo.InvariantCulture,
                "  jadx: {0}", Ex.Message));
            return 0;
        }
        finally
        {
            try
            {
                if (Directory.Exists(TempDir))
                {
                    Directory.Delete(TempDir, true);
                }
            }
            catch
            {
            }
        }
    }

    private static string ResolveJadxPath()
    {
        var EnvPath = Environment.GetEnvironmentVariable("JADX_PATH");
        if (!string.IsNullOrEmpty(EnvPath) && File.Exists(EnvPath))
        {
            return EnvPath;
        }

        var KnownPaths = new[]
        {
            @"C:\work\jadx\build\jadx\bin\jadx.bat",
            @"C:\work\apktools\jadx\bin\jadx.bat",
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "jadx", "bin", "jadx.bat"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "jadx", "bin", "jadx"),
            "/usr/local/bin/jadx",
            "/usr/bin/jadx",
        };

        foreach (var P in KnownPaths)
        {
            if (File.Exists(P))
            {
                return P;
            }
        }

        return string.Empty;
    }

    private static string ToPascalCase(string Value)
    {
        if (Value.Length == 0) return Value;
        return char.ToUpperInvariant(Value[0]) + Value[1..];
    }
}
