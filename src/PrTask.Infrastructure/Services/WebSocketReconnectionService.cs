using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public sealed class WebSocketReconnectionService(
    IWssConnectionService WssConnection,
    IConnectionStateService ConnectionState,
    IVisibilitySyncService VisibilitySync,
    ILogger<WebSocketReconnectionService> Logger) : IWebSocketReconnectionService, IDisposable
{
    private readonly ConcurrentQueue<string> MessageQueue = new();
    private CancellationTokenSource? ReconnectCts;
    private string? CurrentEndpoint;
    public int QueuedMessageCount => MessageQueue.Count;
    public async Task StartAsync(string Endpoint, CancellationToken Cancellation = default)
    {
        CurrentEndpoint = Endpoint;
        await StopAsync(Cancellation);
        ReconnectCts = CancellationTokenSource.CreateLinkedTokenSource(Cancellation);
        ConnectionState.SetState(WebSocketConnectionState.Connecting);
        Logger.LogInformation(WebSocketReconnectionConstants.LogStateChanged, WebSocketConnectionState.Connecting);
        try
        {
            await WssConnection.ConnectAsync(Endpoint, ReconnectCts.Token);
            ConnectionState.SetState(WebSocketConnectionState.Connected);
            Logger.LogInformation(WebSocketReconnectionConstants.LogStateChanged, WebSocketConnectionState.Connected);
            await ReplayQueuedMessagesAsync(ReconnectCts.Token);
            _ = Task.Run(() => MonitorConnectionAsync(ReconnectCts.Token), ReconnectCts.Token);
        }
        catch (Exception) when (!Cancellation.IsCancellationRequested)
        {
            ConnectionState.SetState(WebSocketConnectionState.Disconnected);
            Logger.LogWarning(WebSocketReconnectionConstants.LogConnectionLost);
            _ = Task.Run(() => ReconnectLoopAsync(ReconnectCts.Token), ReconnectCts.Token);
        }
    }
    public async Task StopAsync(CancellationToken Cancellation = default)
    {
        if (ReconnectCts is not null)
        {
            await ReconnectCts.CancelAsync();
            ReconnectCts.Dispose();
            ReconnectCts = null;
        }
        try
        {
            await WssConnection.DisconnectAsync(Cancellation);
        }
        catch (WebSocketException)
        {
        }
        ConnectionState.SetState(WebSocketConnectionState.Disconnected);
    }
    public async Task SendOrQueueAsync(string Message, CancellationToken Cancellation = default)
    {
        if (WssConnection.IsConnected && !await VisibilitySync.IsSyncPausedAsync())
        {
            await WssConnection.SendAsync(Message, Cancellation);
            return;
        }
        if (MessageQueue.Count < WebSocketReconnectionConstants.MessageQueueCapacity)
        {
            MessageQueue.Enqueue(Message);
            Logger.LogDebug(WebSocketReconnectionConstants.LogQueuedMessage, MessageQueue.Count);
        }
    }
    private async Task MonitorConnectionAsync(CancellationToken Cancellation)
    {
        try
        {
            while (!Cancellation.IsCancellationRequested)
            {
                await Task.Delay(WssConstants.PingIntervalMs, Cancellation);
                if (!WssConnection.IsConnected && !Cancellation.IsCancellationRequested)
                {
                    Logger.LogWarning(WebSocketReconnectionConstants.LogConnectionLost);
                    ConnectionState.SetState(WebSocketConnectionState.Reconnecting);
                    await ReconnectLoopAsync(Cancellation);
                    return;
                }
            }
        }
        catch (OperationCanceledException)
        {
        }
    }
    private async Task ReconnectLoopAsync(CancellationToken Cancellation)
    {
        var AttemptCount = 0;
        ConnectionState.SetState(WebSocketConnectionState.Reconnecting);
        while (!Cancellation.IsCancellationRequested && AttemptCount < WebSocketReconnectionConstants.MaxRetryCount)
        {
            AttemptCount++;
            var DelayMs = CalculateBackoffDelay(AttemptCount);
            Logger.LogInformation(WebSocketReconnectionConstants.LogDelayCalculated, DelayMs, AttemptCount);
            Logger.LogInformation(
                WebSocketReconnectionConstants.LogReconnecting,
                AttemptCount,
                WebSocketReconnectionConstants.MaxRetryCount);
            try
            {
                await Task.Delay(DelayMs, Cancellation);
                await WssConnection.ConnectAsync(CurrentEndpoint!, Cancellation);
                if (WssConnection.IsConnected)
                {
                    ConnectionState.SetState(WebSocketConnectionState.Connected);
                    Logger.LogInformation(WebSocketReconnectionConstants.LogReconnected, AttemptCount);
                    await ReplayQueuedMessagesAsync(Cancellation);
                    _ = Task.Run(() => MonitorConnectionAsync(Cancellation), Cancellation);
                    return;
                }
            }
            catch (Exception) when (!Cancellation.IsCancellationRequested)
            {
            }
        }
        if (!Cancellation.IsCancellationRequested)
        {
            ConnectionState.SetState(WebSocketConnectionState.Disconnected);
            Logger.LogError(
                WebSocketReconnectionConstants.LogReconnectFailed,
                WebSocketReconnectionConstants.MaxRetryCount);
        }
    }
    private async Task ReplayQueuedMessagesAsync(CancellationToken Cancellation)
    {
        var Count = MessageQueue.Count;
        if (Count == 0)
        {
            return;
        }
        Logger.LogInformation(WebSocketReconnectionConstants.LogReplayingMessages, Count);
        while (MessageQueue.TryDequeue(out var Message) && !Cancellation.IsCancellationRequested)
        {
            try
            {
                await WssConnection.SendAsync(Message, Cancellation);
            }
            catch (WebSocketException)
            {
                MessageQueue.Enqueue(Message);
                break;
            }
        }
    }
    internal static int CalculateBackoffDelay(int Attempt)
    {
        var BaseDelay = WebSocketReconnectionConstants.InitialDelayMs
            * Math.Pow(WebSocketReconnectionConstants.BackoffFactor, Attempt - 1);
        var ClampedDelay = Math.Min(BaseDelay, WebSocketReconnectionConstants.MaxDelayMs);
        var JitterRange = ClampedDelay * WebSocketReconnectionConstants.JitterFraction;
        var Jitter = (RandomNumberGenerator.GetInt32(WebSocketReconnectionConstants.JitterRandomUpperBound)
            / WebSocketReconnectionConstants.JitterRandomDivisor * JitterRange * 2) - JitterRange;
        return (int)Math.Max(ClampedDelay + Jitter, WebSocketReconnectionConstants.InitialDelayMs);
    }
    public void Dispose()
    {
        ReconnectCts?.Cancel();
        ReconnectCts?.Dispose();
    }
}
