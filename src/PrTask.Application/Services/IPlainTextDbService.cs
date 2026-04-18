namespace PrTask.Application.Services;
public interface IPlainTextDbService
{
    Task<string> ReadAsync(string Collection, string Id);
    Task WriteAsync(string Collection, string Id, string JsonData);
    Task DeleteAsync(string Collection, string Id);
    Task<IReadOnlyList<string>> ListAsync(string Collection);
    Task<string> ExportCollectionAsync(string Collection);
    Task ImportCollectionAsync(string Collection, string JsonArrayData);
}
