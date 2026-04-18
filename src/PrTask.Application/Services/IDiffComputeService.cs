using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IDiffComputeService
{
    DiffResultModel ComputeDiff(string OldText, string NewText);
    string DetectLanguage(string FileName);
    string TokenizeLine(string Text, string Language);
}
