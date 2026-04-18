namespace WillowMaze.Wasm.Decompiled;


public interface ClientHealthMetricsStore {
    com.google.android.datatransport.runtime.firebase.transport.ClientMetrics loadClientMetrics();

    void recordConsoleEventDropped(long j, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, java.lang.string str);

    void resetClientMetrics();
}

