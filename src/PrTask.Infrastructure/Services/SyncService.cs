using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
using PrTask.Infrastructure.NativeMethods;
namespace PrTask.Infrastructure.Services;

#pragma warning disable CA2216
public sealed partial class SyncService : ISyncService, IDisposable
#pragma warning restore CA2216
{
    private readonly ILogger<SyncService> Logger;
    private readonly IHttpClientFactory HttpFactory;
    private readonly bool NativeAvailable;
    private readonly nint Document;
    private readonly System.Threading.Lock DocLock = new();
    private readonly ConcurrentQueue<(string EntityType, string EntityId)> PendingChanges = new();
    private ClientWebSocket? DiffSocket;
    private CancellationTokenSource? DiffCts;
    private long SnapshotTimestamp;
    private string SyncStatus;

    public event EventHandler<DiffPatchEventArgs>? OnDiffPatchReceived;
    public bool IsDiffSyncConnected => DiffSocket?.State == WebSocketState.Open;

    public SyncService(ILogger<SyncService> Logger, IHttpClientFactory HttpFactory)
    {
        this.Logger = Logger;
        this.HttpFactory = HttpFactory;
        SyncStatus = AiConstants.SyncStatusNotConfigured;
        NativeAvailable = NativeLibrary.TryLoad(
            AiConstants.SyncProviderAutomerge.ToLowerInvariant(),
            typeof(AutomergeNative).Assembly,
            null,
            out _);

        if (NativeAvailable)
        {
            var Result = AutomergeNative.Create(nint.Zero);
            var Status = AutomergeNative.ResultStatus(Result);
            if (Status == 0)
            {
                Document = AutomergeNative.ItemToDoc(Result);
                Logger.LogInformation(AiConstants.LogAutomergeLoaded);
            }
            else
            {
                AutomergeNative.ResultFree(Result);
                NativeAvailable = false;
                Logger.LogWarning(AiConstants.LogAutomergeNotFound);
            }
        }
        else
        {
            Logger.LogWarning(AiConstants.LogAutomergeNotFound);
        }
    }

    public Task SyncAsync()
    {
        if (!NativeAvailable)
        {
            return Task.CompletedTask;
        }

        lock (DocLock)
        {
            while (PendingChanges.TryDequeue(out var Change))
            {
                var Key = FormatStrings.SyncChangeKey(Change.EntityType, Change.EntityId);
                var KeyBytes = Encoding.UTF8.GetBytes(Key);
                var ValueBytes = Encoding.UTF8.GetBytes(Change.EntityId);
                unsafe
                {
                    fixed (byte* KeyPtr = KeyBytes)
                    {
                        fixed (byte* ValuePtr = ValueBytes)
                        {
                            var PutResult = AutomergeNative.MapPutStr(
                                Document, nint.Zero,
                                (nint)KeyPtr, KeyBytes.Length,
                                (nint)ValuePtr, ValueBytes.Length);
                            AutomergeNative.ResultFree(PutResult);
                        }
                    }
                }
            }
        }

        return Task.CompletedTask;
    }

    public Task<string> GetSyncStatusAsync() => Task.FromResult(SyncStatus);

    public Task RegisterChangeAsync(string EntityType, string EntityId)
    {
        Logger.LogInformation(AiConstants.LogSyncRegistered, EntityType, EntityId);
        if (NativeAvailable)
        {
            PendingChanges.Enqueue((EntityType, EntityId));
        }

        return Task.CompletedTask;
    }

    private void ApplyDiffToAutomerge(string Collection, string Operation, string Data)
    {
        if (!NativeAvailable)
        {
            return;
        }

        lock (DocLock)
        {
            var Key = FormatStrings.SyncChangeKey(Collection, Operation);
            var KeyBytes = Encoding.UTF8.GetBytes(Key);
            var ValueBytes = Encoding.UTF8.GetBytes(Data);
            unsafe
            {
                fixed (byte* KeyPtr = KeyBytes)
                {
                    fixed (byte* ValuePtr = ValueBytes)
                    {
                        var PutResult = AutomergeNative.MapPutStr(
                            Document, nint.Zero,
                            (nint)KeyPtr, KeyBytes.Length,
                            (nint)ValuePtr, ValueBytes.Length);
                        AutomergeNative.ResultFree(PutResult);
                    }
                }
            }
        }
    }

    public void Dispose()
    {
        DiffCts?.Cancel();
        DiffCts?.Dispose();
        if (DiffSocket?.State == WebSocketState.Open)
        {
            try
            {
                DiffSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None)
                    .GetAwaiter().GetResult();
            }
            catch (WebSocketException)
            {
            }
        }
        DiffSocket?.Dispose();
        if (NativeAvailable && Document != nint.Zero)
        {
            AutomergeNative.Free(Document);
        }
        Logger.LogInformation(AiConstants.LogSyncDisposed);
    }
}
