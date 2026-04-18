using System.Net.Http;
namespace PrTask.E2E;
public partial class RulesTests
{
   private static readonly string ErrorLogPath = Path.Combine(SolutionRoot, "output", "e2e-errors.log");
   private static readonly string UrlVisitLogPath = Path.Combine(SolutionRoot, "output", "e2e-url-visits.log");
   private static readonly HashSet<string> CurrentTestVisitedUrls = new(StringComparer.OrdinalIgnoreCase);
   private static readonly Lock UrlLock = new();
   private static readonly Lock ErrorLogLock = new();
   private static string CurrentTestName = string.Empty;
   private static void ResetUrlTrackingForTest(string TestName)
   {
       lock (UrlLock)
       {
           CurrentTestVisitedUrls.Clear();
           CurrentTestName = TestName;
           Directory.CreateDirectory(Path.GetDirectoryName(UrlVisitLogPath)!);
           File.AppendAllText(UrlVisitLogPath,
               $"[{DateTime.UtcNow:O}] === TEST: {TestName} ===" + Environment.NewLine);
       }
   }
   private static void TrackUrlVisit(string Url)
   {
       var NormalizedUrl = Url.TrimEnd('/');
       if (string.IsNullOrEmpty(NormalizedUrl)) { NormalizedUrl = "/"; }
       lock (UrlLock)
       {
           Directory.CreateDirectory(Path.GetDirectoryName(UrlVisitLogPath)!);
           File.AppendAllText(UrlVisitLogPath,
               $"[{DateTime.UtcNow:O}] VISIT: {NormalizedUrl}" + Environment.NewLine);
           if (!CurrentTestVisitedUrls.Add(NormalizedUrl))
           {
               var ErrorMsg = $"DUPLICATE URL in test '{CurrentTestName}': {NormalizedUrl} — already visited in this test. Merge steps.";
               LogError(ErrorMsg);
               Assert.Fail(ErrorMsg);
           }
       }
   }
   private static void LogWarning(string Message)
   {
       var Line = $"[{DateTime.UtcNow:O}] WARN: {Message}";
       lock (ErrorLogLock)
       {
           Directory.CreateDirectory(Path.GetDirectoryName(ErrorLogPath)!);
           File.AppendAllText(ErrorLogPath, Line + Environment.NewLine);
       }
   }
   private static void LogError(string Message)
   {
       var Line = $"[{DateTime.UtcNow:O}] ERROR: {Message}";
       lock (ErrorLogLock)
       {
           Directory.CreateDirectory(Path.GetDirectoryName(ErrorLogPath)!);
           File.AppendAllText(ErrorLogPath, Line + Environment.NewLine);
       }
   }
   private static async Task<HttpResponseMessage> GetOrSkipAsync(string Url, bool AllowNonSuccess = false)
   {
       TrackUrlVisit(Url);
       try
       {
           var Response = await LiveClient.GetAsync(Url);
           if (!Response.IsSuccessStatusCode && Response.StatusCode != System.Net.HttpStatusCode.Found
               && Response.StatusCode != System.Net.HttpStatusCode.Unauthorized)
           {
               var Body = await Response.Content.ReadAsStringAsync();
               var Trimmed = Body.Length > 2000 ? Body[..2000] + "...(truncated)" : Body;
               var PlaintextLogPath = Path.Combine(SolutionRoot, "output", "e2e-page-plaintext.log");
               Directory.CreateDirectory(Path.GetDirectoryName(PlaintextLogPath)!);
               File.AppendAllText(PlaintextLogPath,
                   $"\n=== {DateTime.UtcNow:O} === GET {Url} {(int)Response.StatusCode} ===\n{Body}\n");
               if (!AllowNonSuccess)
               {
                   LogError($"GET {Url} returned {(int)Response.StatusCode} {Response.StatusCode}\nBody:\n{Trimmed}");
                   Assert.Fail($"GET {Url} returned {(int)Response.StatusCode}. Body logged to output/e2e-page-plaintext.log");
               }
               LogWarning($"GET {Url} returned {(int)Response.StatusCode} (allowed)");
           }
           return Response;
       }
       catch (HttpRequestException Ex)
       {
           LogError($"GET {Url} failed: {Ex.Message}");
           Assert.Fail($"GET {Url} failed: {Ex.Message}");
           return null!;
       }
       catch (TaskCanceledException Ex)
       {
           LogError($"GET {Url} timeout: {Ex.Message}");
           Assert.Fail($"GET {Url} timeout: {Ex.Message}");
           return null!;
       }
   }
}

