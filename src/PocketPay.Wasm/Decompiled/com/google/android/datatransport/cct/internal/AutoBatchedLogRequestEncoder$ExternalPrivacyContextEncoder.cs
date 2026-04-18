namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$ExternalPrivacyobjectEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.ExternalPrivacyobject> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExternalPrivacyobjectEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExternalPrivacyobjectEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor PREQUEST_DESCRIPTOR = NJkPBlXxglwPjkyc("prequest");

    private AutoBatchedConsoleRequestEncoder$ExternalPrivacyobjectEncoder() {
    }

    public static com.google.firebase.encoders.objectEncoderobject KBTeLsWphIXkxNaL(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor NJkPBlXxglwPjkyc(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void QmxjmwOZNgdiBvPZ(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExternalPrivacyobjectEncoder autoBatchedConsoleRequestEncoder$ExternalPrivacyobjectEncoder, com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$ExternalPrivacyobjectEncoder.encode(externalPrivacyobject, objectEncoderobject);
    }

    public static com.google.android.datatransport.cct.internal.ExternalPRequestobject PzYFkpSernoaejEm(com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject) {
        return externalPrivacyobject.getPrequest();
    }

    public void Encode(com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        KBTeLsWphIXkxNaL(objectEncoderobject, PREQUEST_DESCRIPTOR, pzYFkpSernoaejEm(externalPrivacyobject));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        QmxjmwOZNgdiBvPZ(this, (com.google.android.datatransport.cct.internal.ExternalPrivacyobject) obj, objectEncoderobject);
    }
}

