namespace PrTask.Domain.Models;
public sealed class DiffPatchEventArgs(string Collection, string Operation, string Data) : EventArgs
{
    public string Collection { get; } = Collection;
    public string Operation { get; } = Operation;
    public string Data { get; } = Data;
}
