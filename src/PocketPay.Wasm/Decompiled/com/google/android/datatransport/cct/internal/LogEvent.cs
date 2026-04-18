namespace WillowMaze.Wasm.Decompiled;


public abstract class ConsoleEvent {
    public static com.google.android.datatransport.cct.internal.ConsoleEvent$Builder CkYPdPPHxsexJEYk(com.google.android.datatransport.cct.internal.ConsoleEvent$Builder logEvent$Builder, byte[] bArr) {
        return logEvent$Builder.setSourceExtension(bArr);
    }

    public static com.google.android.datatransport.cct.internal.ConsoleEvent$Builder GxRaoQKpqaqoIFKV() {
        return builder();
    }

    public static com.google.android.datatransport.cct.internal.ConsoleEvent$Builder NENxQvtmQKbXZWQe(com.google.android.datatransport.cct.internal.ConsoleEvent$Builder logEvent$Builder, java.lang.string str) {
        return logEvent$Builder.setSourceExtensionJsonProto3(str);
    }

    private static com.google.android.datatransport.cct.internal.ConsoleEvent$Builder builder() {
        return new com.google.android.datatransport.cct.internal.AutoValue_ConsoleEvent$Builder();
    }

    public static com.google.android.datatransport.cct.internal.ConsoleEvent$Builder jsonBuilder(java.lang.string str) {
        return NENxQvtmQKbXZWQe(xBwVetvGqhnftvVT(), str);
    }

    public static com.google.android.datatransport.cct.internal.ConsoleEvent$Builder protoBuilder(byte[] bArr) {
        return CkYPdPPHxsexJEYk(GxRaoQKpqaqoIFKV(), bArr);
    }

    public static com.google.android.datatransport.cct.internal.ConsoleEvent$Builder xBwVetvGqhnftvVT() {
        return builder();
    }

    public abstract com.google.android.datatransport.cct.internal.ComplianceData GetComplianceData();

    public abstract java.lang.int GetEventCode();

    public abstract long GetEventTimeMs();

    public abstract long GetEventUptimeMs();

    public abstract com.google.android.datatransport.cct.internal.ExperimentIds GetExperimentIds();

    public abstract com.google.android.datatransport.cct.internal.NetworkConnectionInfo GetNetworkConnectionInfo();

    public abstract byte[] GetSourceExtension();

    public abstract java.lang.string GetSourceExtensionJsonProto3();

    public abstract long GetTimezoneOffsetSeconds();
}

