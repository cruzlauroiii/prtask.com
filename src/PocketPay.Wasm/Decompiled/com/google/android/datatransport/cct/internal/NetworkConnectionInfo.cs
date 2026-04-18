namespace WillowMaze.Wasm.Decompiled;


public abstract class NetworkConnectionInfo {
    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$Builder builder() {
        return new com.google.android.datatransport.cct.internal.AutoValue_NetworkConnectionInfo$Builder();
    }

    public abstract com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype getMobileSubtype();

    public abstract com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType getNetworkType();
}

