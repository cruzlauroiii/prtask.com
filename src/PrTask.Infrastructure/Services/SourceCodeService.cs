using System.Text;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class SourceCodeService : ISourceCodeService
{
    private static readonly Dictionary<string, IDictionary<string, string>> OriginalFiles = [];
    private static readonly Dictionary<string, IDictionary<string, string>> ModifiedFiles = [];
    public Task StoreFilesAsync(string TaskId, IDictionary<string, string> Files)
    {
        OriginalFiles[TaskId] = new Dictionary<string, string>(Files);
        return Task.CompletedTask;
    }
    public Task<IDictionary<string, string>> GetFilesAsync(string TaskId) =>
        Task.FromResult(OriginalFiles.TryGetValue(TaskId, out var Files)
            ? Files : (IDictionary<string, string>)new Dictionary<string, string>());
    public Task StoreModifiedFilesAsync(string TaskId, string PrId, IDictionary<string, string> Files)
    {
        var Key = string.Format(SourceCodeConstants.KeyFormat, TaskId, PrId);
        ModifiedFiles[Key] = new Dictionary<string, string>(Files);
        return Task.CompletedTask;
    }
    public Task<IDictionary<string, string>> GetModifiedFilesAsync(string TaskId, string PrId) =>
        Task.FromResult(ModifiedFiles.TryGetValue(string.Format(SourceCodeConstants.KeyFormat, TaskId, PrId), out var Files)
            ? Files : (IDictionary<string, string>)new Dictionary<string, string>());
    public Task<string> GenerateDiffAsync(string TaskId, string PrId)
    {
        var Original = OriginalFiles.TryGetValue(TaskId, out var Orig)
            ? Orig : new Dictionary<string, string>();
        var Modified = ModifiedFiles.TryGetValue(string.Format(SourceCodeConstants.KeyFormat, TaskId, PrId), out var Mod)
            ? Mod : new Dictionary<string, string>();
        var Sb = new StringBuilder();
        foreach (var File in Original)
        {
            if (!Modified.TryGetValue(File.Key, out var ModContent)) { continue; }
            var OrigLines = File.Value.Split('\n');
            var ModLines = ModContent.Split('\n');
            Sb.AppendFormat(SourceCodeConstants.DiffGitHeader, File.Key).AppendLine()
              .AppendFormat(SourceCodeConstants.DiffOldFile, File.Key).AppendLine()
              .AppendFormat(SourceCodeConstants.DiffNewFile, File.Key).AppendLine();
            for (var I = 0; I < Math.Max(OrigLines.Length, ModLines.Length); I++)
            {
                var O = I < OrigLines.Length ? OrigLines[I] : string.Empty;
                var M = I < ModLines.Length ? ModLines[I] : string.Empty;
                if (O == M) { Sb.AppendFormat(SourceCodeConstants.DiffContextLine, O).AppendLine(); }
                else
                {
                    if (I < OrigLines.Length) { Sb.AppendFormat(SourceCodeConstants.DiffDeleteLine, O).AppendLine(); }
                    if (I < ModLines.Length) { Sb.AppendFormat(SourceCodeConstants.DiffAddLine, M).AppendLine(); }
                }
            }
        }
        foreach (var File in Modified.Where(F => !Original.ContainsKey(F.Key)))
        {
            Sb.AppendFormat(SourceCodeConstants.DiffNewFileHeader, File.Key).AppendLine()
              .AppendFormat(SourceCodeConstants.DiffNewFilePlusHeader, File.Key).AppendLine();
            foreach (var Line in File.Value.Split('\n'))
            {
                Sb.AppendFormat(SourceCodeConstants.DiffAddLine, Line).AppendLine();
            }
        }
        return Task.FromResult(Sb.ToString());
    }
    public Task DeleteFilesAsync(string TaskId)
    {
        OriginalFiles.Remove(TaskId);
        var Prefix = string.Format(SourceCodeConstants.PrefixFormat, TaskId);
        foreach (var Key in ModifiedFiles.Keys.Where(K => K.StartsWith(Prefix, StringComparison.Ordinal)).ToList())
        {
            ModifiedFiles.Remove(Key);
        }
        return Task.CompletedTask;
    }
}
