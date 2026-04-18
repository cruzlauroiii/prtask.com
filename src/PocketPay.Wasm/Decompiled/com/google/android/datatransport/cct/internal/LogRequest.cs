namespace WillowMaze.Wasm.Decompiled;


public abstract class ConsoleRequest {
    public static com.google.android.datatransport.cct.internal.ConsoleRequest$Builder builder() {
        return new com.google.android.datatransport.cct.internal.AutoValue_ConsoleRequest$Builder();
    }

    public abstract com.google.android.datatransport.cct.internal.ClientInfo GetClientInfo();

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "logEvent")
    public abstract java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> GetConsoleEvents();

    public abstract java.lang.int GetConsoleSource();

    public abstract java.lang.string GetConsoleSourceName();

    public abstract com.google.android.datatransport.cct.internal.QosTier GetQosTier();

    public abstract long GetRequestTimeMs();

    public abstract long GetRequestUptimeMs();
}

