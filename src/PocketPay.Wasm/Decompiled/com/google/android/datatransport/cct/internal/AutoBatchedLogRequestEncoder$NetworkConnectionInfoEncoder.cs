namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$NetworkConnectionInfoEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.NetworkConnectionInfo> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$NetworkConnectionInfoEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$NetworkConnectionInfoEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor NETWORKTYPE_DESCRIPTOR = DWxPdWSCYnZCKXUs("networkType");
    private static readonly com.google.firebase.encoders.FieldDescriptor MOBILESUBTYPE_DESCRIPTOR = MgDyRZnnblxQQPmE("mobileSubtype");

    private AutoBatchedConsoleRequestEncoder$NetworkConnectionInfoEncoder() {
    }

    public static com.google.firebase.encoders.FieldDescriptor DWxPdWSCYnZCKXUs(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor MgDyRZnnblxQQPmE(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject QTcilZQTFrQKTwUD(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType XPNrgTOSoNRrEaLF(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo) {
        return networkConnectionInfo.getNetworkType();
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype ayXEkCRgpkTudsSl(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo) {
        return networkConnectionInfo.getMobileSubtype();
    }

    public static void OpoLUVzezaSccAvf(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$NetworkConnectionInfoEncoder autoBatchedConsoleRequestEncoder$NetworkConnectionInfoEncoder, com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$NetworkConnectionInfoEncoder.encode(networkConnectionInfo, objectEncoderobject);
    }

    public static com.google.firebase.encoders.objectEncoderobject USgQvNgZYMaIFqTZ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public void Encode(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        QTcilZQTFrQKTwUD(objectEncoderobject, NETWORKTYPE_DESCRIPTOR, XPNrgTOSoNRrEaLF(networkConnectionInfo));
        uSgQvNgZYMaIFqTZ(objectEncoderobject, MOBILESUBTYPE_DESCRIPTOR, ayXEkCRgpkTudsSl(networkConnectionInfo));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        opoLUVzezaSccAvf(this, (com.google.android.datatransport.cct.internal.NetworkConnectionInfo) obj, objectEncoderobject);
    }
}

