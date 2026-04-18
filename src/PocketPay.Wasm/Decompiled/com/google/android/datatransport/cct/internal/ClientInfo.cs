namespace WillowMaze.Wasm.Decompiled;


public abstract class ClientInfo {
    public static com.google.android.datatransport.cct.internal.ClientInfo$Builder builder() {
        return new com.google.android.datatransport.cct.internal.AutoValue_ClientInfo$Builder();
    }

    public abstract com.google.android.datatransport.cct.internal.AndroidClientInfo GetAndroidClientInfo();

    public abstract com.google.android.datatransport.cct.internal.ClientInfo$ClientType getClientType();
}

