using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpDiffComputeService : IDiffComputeService
{
    public DiffResultModel ComputeDiff(string OldText, string NewText) => new();
    public string DetectLanguage(string FileName) => string.Empty;
    public string TokenizeLine(string Text, string Language) => Text;
}
