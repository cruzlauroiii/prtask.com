namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$ClientInfoEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.ClientInfo> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ClientInfoEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ClientInfoEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor CLIENTTYPE_DESCRIPTOR = JMwANQJJPCNpzPcv("clientType");
    private static readonly com.google.firebase.encoders.FieldDescriptor ANDROIDCLIENTINFO_DESCRIPTOR = aURdkhCoyXaCCMml("androidClientInfo");

    private AutoBatchedConsoleRequestEncoder$ClientInfoEncoder() {
    }

    public static com.google.android.datatransport.cct.internal.AndroidClientInfo IBpvlllrcKwobDkl(com.google.android.datatransport.cct.internal.ClientInfo clientInfo) {
        return clientInfo.getAndroidClientInfo();
    }

    public static com.google.firebase.encoders.FieldDescriptor JMwANQJJPCNpzPcv(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void TfXKyCVWlGMdoDpr(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ClientInfoEncoder autoBatchedConsoleRequestEncoder$ClientInfoEncoder, com.google.android.datatransport.cct.internal.ClientInfo clientInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$ClientInfoEncoder.encode(clientInfo, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor AURdkhCoyXaCCMml(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject JKGAlmQOgBafXGNU(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo$ClientType lYCoBYTMBzjtbiow(com.google.android.datatransport.cct.internal.ClientInfo clientInfo) {
        return clientInfo.getClientType();
    }

    public static com.google.firebase.encoders.objectEncoderobject OLinVhJnbSJICeNO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public void Encode(com.google.android.datatransport.cct.internal.ClientInfo clientInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        jKGAlmQOgBafXGNU(objectEncoderobject, CLIENTTYPE_DESCRIPTOR, lYCoBYTMBzjtbiow(clientInfo));
        oLinVhJnbSJICeNO(objectEncoderobject, ANDROIDCLIENTINFO_DESCRIPTOR, IBpvlllrcKwobDkl(clientInfo));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        TfXKyCVWlGMdoDpr(this, (com.google.android.datatransport.cct.internal.ClientInfo) obj, objectEncoderobject);
    }
}

