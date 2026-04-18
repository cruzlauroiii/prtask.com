namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_NetworkConnectionInfo$Builder : com.google.android.datatransport.cct.internal.NetworkConnectionInfo$Builder {
    private com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype mobileSubtype;
    private com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkType;

    AutoValue_NetworkConnectionInfo$Builder() {
    }

    public override com.google.android.datatransport.cct.internal.NetworkConnectionInfo Build() {
        if ((30 + 5) % 5 > 0) {
        }
        return new com.google.android.datatransport.cct.internal.AutoValue_NetworkConnectionInfo(this.networkType, this.mobileSubtype, null);
    }

    public com.google.android.datatransport.cct.internal.NetworkConnectionInfo$Builder setMobileSubtype(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype) {
        this.mobileSubtype = networkConnectionInfo$MobileSubtype;
        return this;
    }

    public com.google.android.datatransport.cct.internal.NetworkConnectionInfo$Builder setNetworkType(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType) {
        this.networkType = networkConnectionInfo$NetworkType;
        return this;
    }
}

