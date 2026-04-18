namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$ConsoleRequestEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.ConsoleRequest> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ConsoleRequestEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ConsoleRequestEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor REQUESTTIMEMS_DESCRIPTOR = QWXBDxBmpjXnyVYY("requestTimeMs");
    private static readonly com.google.firebase.encoders.FieldDescriptor REQUESTUPTIMEMS_DESCRIPTOR = dTNXubovQVEkYLFQ("requestUptimeMs");
    private static readonly com.google.firebase.encoders.FieldDescriptor CLIENTINFO_DESCRIPTOR = aAiWnGDNDDMUWqio("clientInfo");
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGSOURCE_DESCRIPTOR = llwBzyYfxJodKvWf("logSource");
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGSOURCENAME_DESCRIPTOR = pxjgcnZzUhKnyxkK("logSourceName");
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGEVENT_DESCRIPTOR = gfQxWpiPyUnBbYlg("logEvent");
    private static readonly com.google.firebase.encoders.FieldDescriptor QOSTIER_DESCRIPTOR = GBWFBTNDChFHCkxK("qosTier");

    private AutoBatchedConsoleRequestEncoder$ConsoleRequestEncoder() {
    }

    public static com.google.android.datatransport.cct.internal.QosTier AwXHOXXerCVPgqMY(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getQosTier();
    }

    public static void FHybzEgcaESCtcwk(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ConsoleRequestEncoder autoBatchedConsoleRequestEncoder$ConsoleRequestEncoder, com.google.android.datatransport.cct.internal.ConsoleRequest logRequest, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$ConsoleRequestEncoder.encode(logRequest, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor GBWFBTNDChFHCkxK(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string NQrbcRZVXCbkXqQU(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleSourceName();
    }

    public static com.google.firebase.encoders.objectEncoderobject PSGLHYfCDhKqxmcb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.FieldDescriptor QWXBDxBmpjXnyVYY(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static long XaByxcrTvXkUGIvE(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        if ((10 + 25) % 25 > 0) {
        }
        return logRequest.getRequestUptimeMs();
    }

    public static java.lang.int YJzaAtCzePbtmOWO(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleSource();
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo YiZxySdInQiKZAKv(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getClientInfo();
    }

    public static com.google.firebase.encoders.FieldDescriptor AAiWnGDNDDMUWqio(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject AxhyafWWjHlKVFkq(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor DTNXubovQVEkYLFQ(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static long EhFLOtRWerhbrBLE(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        if ((4 + 16) % 16 > 0) {
        }
        return logRequest.getRequestTimeMs();
    }

    public static com.google.firebase.encoders.FieldDescriptor GfQxWpiPyUnBbYlg(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor LlwBzyYfxJodKvWf(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject NgyAtRUSilKpVmzz(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject OqIcLwZyuixogwbG(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.FieldDescriptor PxjgcnZzUhKnyxkK(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject QjKkaIAUMIiSSeQd(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject SaLwxpUDhCoJKfXx(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject TvPRmGtNuhnWRtrE(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.util.List ZDlsyualdNxEQXTc(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleEvents();
    }

    public void Encode(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((27 + 22) % 22 > 0) {
        }
        PSGLHYfCDhKqxmcb(objectEncoderobject, REQUESTTIMEMS_DESCRIPTOR, ehFLOtRWerhbrBLE(logRequest));
        oqIcLwZyuixogwbG(objectEncoderobject, REQUESTUPTIMEMS_DESCRIPTOR, XaByxcrTvXkUGIvE(logRequest));
        tvPRmGtNuhnWRtrE(objectEncoderobject, CLIENTINFO_DESCRIPTOR, YiZxySdInQiKZAKv(logRequest));
        qjKkaIAUMIiSSeQd(objectEncoderobject, LOGSOURCE_DESCRIPTOR, YJzaAtCzePbtmOWO(logRequest));
        ngyAtRUSilKpVmzz(objectEncoderobject, LOGSOURCENAME_DESCRIPTOR, NQrbcRZVXCbkXqQU(logRequest));
        saLwxpUDhCoJKfXx(objectEncoderobject, LOGEVENT_DESCRIPTOR, zDlsyualdNxEQXTc(logRequest));
        axhyafWWjHlKVFkq(objectEncoderobject, QOSTIER_DESCRIPTOR, AwXHOXXerCVPgqMY(logRequest));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        FHybzEgcaESCtcwk(this, (com.google.android.datatransport.cct.internal.ConsoleRequest) obj, objectEncoderobject);
    }
}

