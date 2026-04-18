namespace WillowMaze.Wasm.Decompiled;


public abstract class ConsoleEvent$Builder {
    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent Build();

    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setComplianceData(com.google.android.datatransport.cct.internal.ComplianceData complianceData);

    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setEventCode(java.lang.int num);

    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setEventTimeMs(long j);

    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setEventUptimeMs(long j);

    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setExperimentIds(com.google.android.datatransport.cct.internal.ExperimentIds experimentIds);

    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setNetworkConnectionInfo(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo);

    abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setSourceExtension(byte[] bArr);

    abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setSourceExtensionJsonProto3(java.lang.string str);

    public abstract com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setTimezoneOffsetSeconds(long j);
}

