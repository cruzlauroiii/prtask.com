namespace WillowMaze.Wasm.Decompiled;


public abstract class ConsoleRequest$Builder {
    public static com.google.android.datatransport.cct.internal.ConsoleRequest$Builder TGqMsqnGwgYsxAzz(com.google.android.datatransport.cct.internal.ConsoleRequest$Builder logRequest$Builder, java.lang.int num) {
        return logRequest$Builder.setConsoleSource(num);
    }

    public static java.lang.int JMOcAKiqVxclqqac(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.datatransport.cct.internal.ConsoleRequest$Builder rzakLiVbIatOwQZr(com.google.android.datatransport.cct.internal.ConsoleRequest$Builder logRequest$Builder, java.lang.string str) {
        return logRequest$Builder.setConsoleSourceName(str);
    }

    public abstract com.google.android.datatransport.cct.internal.ConsoleRequest Build();

    public abstract com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setClientInfo(com.google.android.datatransport.cct.internal.ClientInfo clientInfo);

    public abstract com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setConsoleEvents(java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> list);

    abstract com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setConsoleSource(java.lang.int num);

    abstract com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setConsoleSourceName(java.lang.string str);

    public abstract com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setQosTier(com.google.android.datatransport.cct.internal.QosTier qosTier);

    public abstract com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setRequestTimeMs(long j);

    public abstract com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setRequestUptimeMs(long j);

    public com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setSource(int i) {
        return TGqMsqnGwgYsxAzz(this, jMOcAKiqVxclqqac(i));
    }

    public com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setSource(java.lang.string str) {
        return rzakLiVbIatOwQZr(this, str);
    }
}

