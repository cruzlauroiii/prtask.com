using System.Text.Json;
using Microsoft.JSInterop;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public sealed class LocalStoreService(IJSRuntime JsRuntime) : ILocalStoreService
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public async Task InitAsync() =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.Init);

    public async Task<string?> ReadFileAsync(string Path) =>
        await JsRuntime.InvokeAsync<string?>(OpfsConstants.ReadFile, Path);

    public async Task WriteFileAsync(string Path, string Content) =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.WriteFile, Path, Content);

    public async Task DeleteFileAsync(string Path) =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.DeleteFile, Path);

    public async Task<string[]> ListFilesAsync(string Directory)
    {
        var Result = await JsRuntime.InvokeAsync<string[]?>(OpfsConstants.ListFiles, Directory);
        return Result ?? [];
    }

    public async Task<bool> FileExistsAsync(string Path) =>
        await JsRuntime.InvokeAsync<bool>(OpfsConstants.FileExists, Path);

    public async Task WriteBytesAsync(string Path, byte[] Bytes)
    {
        var Base64 = Convert.ToBase64String(Bytes);
        await JsRuntime.InvokeVoidAsync(OpfsConstants.WriteFile, Path, Base64);
    }

    public async Task<byte[]?> ReadBytesAsync(string Path)
    {
        var Base64 = await JsRuntime.InvokeAsync<string?>(OpfsConstants.ReadFile, Path);
        return Base64 is null ? null : Convert.FromBase64String(Base64);
    }

    public async Task<T[]> GetRecordsAsync<T>(string Collection)
    {
        var Element = await JsRuntime.InvokeAsync<JsonElement>(OpfsConstants.GetRecords, Collection);
        if (Element.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
        {
            return [];
        }
        var Json = Element.GetRawText();
        return JsonSerializer.Deserialize<T[]>(Json, JsonOptions) ?? [];
    }

    public async Task<T?> GetRecordAsync<T>(string Collection, string Id)
    {
        var Element = await JsRuntime.InvokeAsync<JsonElement>(OpfsConstants.GetRecord, Collection, Id);
        if (Element.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
        {
            return default;
        }
        var Json = Element.GetRawText();
        return JsonSerializer.Deserialize<T>(Json, JsonOptions);
    }

    public async Task SaveRecordAsync<T>(string Collection, T Record) =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.SaveRecord, Collection, Record);

    public async Task DeleteRecordAsync(string Collection, string Id) =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.DeleteRecord, Collection, Id);

    public async Task QueueMutationAsync(object Mutation) =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.QueueMutation, Mutation);

    public async Task<object[]> GetQueueAsync()
    {
        var Element = await JsRuntime.InvokeAsync<JsonElement>(OpfsConstants.GetQueue);
        if (Element.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
        {
            return [];
        }
        var Json = Element.GetRawText();
        return JsonSerializer.Deserialize<object[]>(Json, JsonOptions) ?? [];
    }

    public async Task ClearQueueAsync() =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.ClearQueue);

    public async Task<string?> GetMetaAsync(string Key) =>
        await JsRuntime.InvokeAsync<string?>(OpfsConstants.GetMeta, Key);

    public async Task SetMetaAsync(string Key, string Value) =>
        await JsRuntime.InvokeVoidAsync(OpfsConstants.SetMeta, Key, Value);
}
