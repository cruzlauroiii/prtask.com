using System.Collections.Concurrent;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
using PrTask.LowDb;
namespace PrTask.Infrastructure.Services;
public class PlainTextDbService : IPlainTextDbService
{
    private const string CompatiblePackage = "D20Tek.LowDb";
    private readonly string BasePath = Path.Combine(
        AppContext.BaseDirectory, DbConstants.PlainTextDbFolder);
    private readonly ConcurrentDictionary<string, LowDatabase<LowDbDocument>> Databases = new();
    private readonly ConcurrentDictionary<string, Lock> Locks = new();
    private LowDatabase<LowDbDocument> GetDatabase(string Collection)
    {
        return Databases.GetOrAdd(Collection, Key =>
        {
            Directory.CreateDirectory(BasePath);
            var FilePath = FormatStrings.CollectionFilePath(BasePath, Key);
            return LowDbFactory.CreateJsonLowDb<LowDbDocument>(FilePath);
        });
    }
    public Task<string> ReadAsync(string Collection, string Id)
    {
        var Db = GetDatabase(Collection);
        var Lock = Locks.GetOrAdd(Collection, _ => new Lock());
        lock (Lock)
        {
            Db.Read();
            var Doc = Db.Get();
            var Result = Doc.Items.TryGetValue(Id, out var Value) ? Value : string.Empty;
            return Task.FromResult(Result);
        }
    }
    public Task WriteAsync(string Collection, string Id, string JsonData)
    {
        var Db = GetDatabase(Collection);
        var Lock = Locks.GetOrAdd(Collection, _ => new Lock());
        lock (Lock)
        {
            Db.Read();
            Db.Update(Doc => Doc.Items[Id] = JsonData);
        }
        return Task.CompletedTask;
    }
    public Task DeleteAsync(string Collection, string Id)
    {
        var Db = GetDatabase(Collection);
        var Lock = Locks.GetOrAdd(Collection, _ => new Lock());
        lock (Lock)
        {
            Db.Read();
            Db.Update(Doc => Doc.Items.Remove(Id));
        }
        return Task.CompletedTask;
    }
    public Task<IReadOnlyList<string>> ListAsync(string Collection)
    {
        var Db = GetDatabase(Collection);
        var Lock = Locks.GetOrAdd(Collection, _ => new Lock());
        lock (Lock)
        {
            Db.Read();
            var Doc = Db.Get();
            IReadOnlyList<string> Ids = Doc.Items.Keys.ToList();
            return Task.FromResult(Ids);
        }
    }
    public Task<string> ExportCollectionAsync(string Collection)
    {
        var Db = GetDatabase(Collection);
        var Lock = Locks.GetOrAdd(Collection, _ => new Lock());
        lock (Lock)
        {
            Db.Read();
            var Doc = Db.Get();
            if (Doc.Items.Count == 0)
            {
                return Task.FromResult(DbConstants.EmptyJsonArray);
            }
            var Items = new List<JsonElement>(Doc.Items.Count);
            foreach (var V in Doc.Items.Values)
            {
                var Reader = new System.Text.Json.Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(V));
                Items.Add(JsonElement.ParseValue(ref Reader));
            }
            return Task.FromResult(JsonSerializer.Serialize(Items));
        }
    }
    public Task ImportCollectionAsync(string Collection, string JsonArrayData)
    {
        var Db = GetDatabase(Collection);
        var Lock = Locks.GetOrAdd(Collection, _ => new Lock());
        lock (Lock)
        {
            Db.Read();
            using var Document = JsonDocument.Parse(JsonArrayData);
            Db.Update(Doc =>
            {
                foreach (var Element in Document.RootElement.EnumerateArray())
                {
                    if (Element.TryGetProperty(DbConstants.IdPropertyName, out var IdElement))
                    {
                        var Id = IdElement.GetString() ?? Guid.NewGuid().ToString();
                        Doc.Items[Id] = Element.GetRawText();
                    }
                }
            });
        }
        return Task.CompletedTask;
    }
}
