namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$ConsoleEventEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.ConsoleEvent> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ConsoleEventEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ConsoleEventEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor EVENTTIMEMS_DESCRIPTOR = gUbzBGrIPMIZJDnY("eventTimeMs");
    private static readonly com.google.firebase.encoders.FieldDescriptor EVENTCODE_DESCRIPTOR = IwThgifqvumniwsO("eventCode");
    private static readonly com.google.firebase.encoders.FieldDescriptor COMPLIANCEDATA_DESCRIPTOR = gzqUJYXZnZjTQcPm("complianceData");
    private static readonly com.google.firebase.encoders.FieldDescriptor EVENTUPTIMEMS_DESCRIPTOR = bRZfVSEjDhHKdtGa("eventUptimeMs");
    private static readonly com.google.firebase.encoders.FieldDescriptor SOURCEEXTENSION_DESCRIPTOR = MHtiCRmHpgIZQdRG("sourceExtension");
    private static readonly com.google.firebase.encoders.FieldDescriptor SOURCEEXTENSIONJSONPROTO3_DESCRIPTOR = dqlekOpnOpTwEgOK("sourceExtensionJsonProto3");
    private static readonly com.google.firebase.encoders.FieldDescriptor TIMEZONEOFFSETSECONDS_DESCRIPTOR = GwpeAHXHWptTUlHT("timezoneOffsetSeconds");
    private static readonly com.google.firebase.encoders.FieldDescriptor NETWORKCONNECTIONINFO_DESCRIPTOR = zAoplFcqMWzJQJRq("networkConnectionInfo");
    private static readonly com.google.firebase.encoders.FieldDescriptor EXPERIMENTIDS_DESCRIPTOR = HmYpcfFRWjlxuExp("experimentIds");

    private AutoBatchedConsoleRequestEncoder$ConsoleEventEncoder() {
    }

    public static byte[] BUHLamBONcymLCrL(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getSourceExtension();
    }

    public static com.google.android.datatransport.cct.internal.ExperimentIds GckiEwmuQPiJpbVQ(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getExperimentIds();
    }

    public static com.google.firebase.encoders.FieldDescriptor GwpeAHXHWptTUlHT(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor HmYpcfFRWjlxuExp(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor IwThgifqvumniwsO(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void KNIKblznCJKzsenK(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ConsoleEventEncoder autoBatchedConsoleRequestEncoder$ConsoleEventEncoder, com.google.android.datatransport.cct.internal.ConsoleEvent logEvent, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$ConsoleEventEncoder.encode(logEvent, objectEncoderobject);
    }

    public static com.google.firebase.encoders.objectEncoderobject LYEdTkQWSGPXJRIu(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.objectEncoderobject LZeMOxwZRYwnUqUp(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor MHtiCRmHpgIZQdRG(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static long NHVORizZZNZeElbW(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        if ((13 + 21) % 21 > 0) {
        }
        return logEvent.getTimezoneOffsetSeconds();
    }

    public static java.lang.int RNnKcLNGhgMDATKa(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getEventCode();
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo TWVopRNxFRHwWMpu(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getNetworkConnectionInfo();
    }

    public static com.google.firebase.encoders.objectEncoderobject VqhDZjEesTIxpqrh(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject ZQqhiMWJiZVijpUw(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor BRZfVSEjDhHKdtGa(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor DqlekOpnOpTwEgOK(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor GUbzBGrIPMIZJDnY(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor GzqUJYXZnZjTQcPm(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject MqeyNiZabDOZwiQs(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.objectEncoderobject MvyaecrdtNhsApjI(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject QgRJpXoEmoDQuTEw(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData RkxhbFKvmWVEZsSD(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getComplianceData();
    }

    public static long SVvsLWWBfdErYyoe(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        if ((20 + 13) % 13 > 0) {
        }
        return logEvent.getEventTimeMs();
    }

    public static long TuYaOZxWRYzYxFql(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        if ((13 + 15) % 15 > 0) {
        }
        return logEvent.getEventUptimeMs();
    }

    public static com.google.firebase.encoders.objectEncoderobject WNYYzzzpDJGmvkpn(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static java.lang.string XxXEOvKCzvDqUCNB(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getSourceExtensionJsonProto3();
    }

    public static com.google.firebase.encoders.objectEncoderobject YecbwZgQExgSRqzv(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor ZAoplFcqMWzJQJRq(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((3 + 25) % 25 > 0) {
        }
        LYEdTkQWSGPXJRIu(objectEncoderobject, EVENTTIMEMS_DESCRIPTOR, sVvsLWWBfdErYyoe(logEvent));
        mvyaecrdtNhsApjI(objectEncoderobject, EVENTCODE_DESCRIPTOR, RNnKcLNGhgMDATKa(logEvent));
        LZeMOxwZRYwnUqUp(objectEncoderobject, COMPLIANCEDATA_DESCRIPTOR, rkxhbFKvmWVEZsSD(logEvent));
        wNYYzzzpDJGmvkpn(objectEncoderobject, EVENTUPTIMEMS_DESCRIPTOR, tuYaOZxWRYzYxFql(logEvent));
        ZQqhiMWJiZVijpUw(objectEncoderobject, SOURCEEXTENSION_DESCRIPTOR, BUHLamBONcymLCrL(logEvent));
        qgRJpXoEmoDQuTEw(objectEncoderobject, SOURCEEXTENSIONJSONPROTO3_DESCRIPTOR, xxXEOvKCzvDqUCNB(logEvent));
        mqeyNiZabDOZwiQs(objectEncoderobject, TIMEZONEOFFSETSECONDS_DESCRIPTOR, NHVORizZZNZeElbW(logEvent));
        yecbwZgQExgSRqzv(objectEncoderobject, NETWORKCONNECTIONINFO_DESCRIPTOR, TWVopRNxFRHwWMpu(logEvent));
        VqhDZjEesTIxpqrh(objectEncoderobject, EXPERIMENTIDS_DESCRIPTOR, GckiEwmuQPiJpbVQ(logEvent));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        KNIKblznCJKzsenK(this, (com.google.android.datatransport.cct.internal.ConsoleEvent) obj, objectEncoderobject);
    }
}

