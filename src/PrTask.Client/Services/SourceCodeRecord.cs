#pragma warning disable CA1812
namespace PrTask.Client.Services;
internal sealed class SourceCodeRecord
{
    public string Id { get; set; } = string.Empty;
    public IDictionary<string, string> Files { get; set; } = new Dictionary<string, string>();
}
