using System.Collections.Concurrent;
using System.Text.Json;

namespace WillowMaze.Server;

internal sealed class Store<T> where T : class, IHasId
{
    private readonly ConcurrentDictionary<string, T> _items = new();
    private readonly string _filePath;
    private readonly object _writeLock = new();
    private static readonly JsonSerializerOptions Json = new() { PropertyNamingPolicy = null, WriteIndented = false };

    public Store(string filePath)
    {
        _filePath = filePath;
        Load();
    }

    public IReadOnlyCollection<T> All => _items.Values.ToArray();
    public int Count => _items.Count;
    public T? Get(string id) => _items.TryGetValue(id, out var v) ? v : null;

    public T Upsert(T item)
    {
        _items[item.Id] = item;
        Persist(item);
        return item;
    }

    public bool Remove(string id) => _items.TryRemove(id, out _);

    private void Load()
    {
        if (!File.Exists(_filePath)) return;
        foreach (var line in File.ReadAllLines(_filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            try
            {
                var item = JsonSerializer.Deserialize<T>(line, Json);
                if (item is not null) _items[item.Id] = item;
            }
            catch { }
        }
    }

    private void Persist(T item)
    {
        lock (_writeLock)
        {
            File.AppendAllText(_filePath, JsonSerializer.Serialize(item, Json) + Environment.NewLine);
        }
    }

    public void Compact()
    {
        lock (_writeLock)
        {
            var lines = _items.Values.Select(v => JsonSerializer.Serialize(v, Json));
            File.WriteAllLines(_filePath, lines);
        }
    }
}

internal interface IHasId
{
    string Id { get; }
}
