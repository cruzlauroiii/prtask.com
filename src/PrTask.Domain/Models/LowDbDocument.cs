namespace PrTask.Domain.Models;
public class LowDbDocument
{
    public IDictionary<string, string> Items { get; } = new Dictionary<string, string>();
}
