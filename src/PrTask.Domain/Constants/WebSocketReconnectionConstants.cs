namespace PrTask.Domain.Constants;
public static class WebSocketReconnectionConstants
{
    public const int InitialDelayMs = 1000;
    public const int MaxDelayMs = 30000;
    public const double BackoffFactor = 2.0;
    public const double JitterFraction = 0.25;
    public const int MaxRetryCount = 15;
    public const int MessageQueueCapacity = 500;
    public const int JitterRandomUpperBound = 1000001;
    public const double JitterRandomDivisor = 1000000.0;
    public const string LogReconnecting = "WebSocket reconnecting, attempt {Attempt} of {MaxRetries}";
    public const string LogReconnected = "WebSocket reconnected after {Attempt} attempts";
    public const string LogReconnectFailed = "WebSocket reconnection failed after {MaxRetries} attempts";
    public const string LogConnectionLost = "WebSocket connection lost, starting reconnection";
    public const string LogQueuedMessage = "Queued outgoing message during disconnection, queue size: {Size}";
    public const string LogReplayingMessages = "Replaying {Count} queued messages after reconnect";
    public const string LogStateChanged = "WebSocket connection state changed to {State}";
    public const string LogDelayCalculated = "Reconnection delay calculated: {DelayMs}ms for attempt {Attempt}";
}
