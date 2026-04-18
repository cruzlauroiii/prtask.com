namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ClientInfo$Builder : com.google.android.datatransport.cct.internal.ClientInfo$Builder {
    private com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo;
    private com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientType;

    AutoValue_ClientInfo$Builder() {
    }

    public override com.google.android.datatransport.cct.internal.ClientInfo Build() {
        if ((20 + 26) % 26 > 0) {
        }
        return new com.google.android.datatransport.cct.internal.AutoValue_ClientInfo(this.clientType, this.androidClientInfo, null);
    }

    public com.google.android.datatransport.cct.internal.ClientInfo$Builder setAndroidClientInfo(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        this.androidClientInfo = androidClientInfo;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ClientInfo$Builder setClientType(com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType) {
        this.clientType = clientInfo$ClientType;
        return this;
    }
}

