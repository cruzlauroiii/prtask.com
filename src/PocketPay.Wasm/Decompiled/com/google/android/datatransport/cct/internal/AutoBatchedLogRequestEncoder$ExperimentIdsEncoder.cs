namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$ExperimentIdsEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.ExperimentIds> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExperimentIdsEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExperimentIdsEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor CLEARBLOB_DESCRIPTOR = nAzoCmTnpQxcGWYG("clearBlob");
    private static readonly com.google.firebase.encoders.FieldDescriptor ENCRYPTEDBLOB_DESCRIPTOR = ORZKPlTgvvIwTbir("encryptedBlob");

    private AutoBatchedConsoleRequestEncoder$ExperimentIdsEncoder() {
    }

    public static void NSRZveYDYiiwdhfK(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExperimentIdsEncoder autoBatchedConsoleRequestEncoder$ExperimentIdsEncoder, com.google.android.datatransport.cct.internal.ExperimentIds experimentIds, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$ExperimentIdsEncoder.encode(experimentIds, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor ORZKPlTgvvIwTbir(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static byte[] TRTksUUvWmMsCIFu(com.google.android.datatransport.cct.internal.ExperimentIds experimentIds) {
        return experimentIds.getClearBlob();
    }

    public static com.google.firebase.encoders.objectEncoderobject CPPQCQGMtajlfzoo(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject JOmpaobDlEJZxAjD(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static byte[] KKSlblhLUqVWoUiI(com.google.android.datatransport.cct.internal.ExperimentIds experimentIds) {
        return experimentIds.getEncryptedBlob();
    }

    public static com.google.firebase.encoders.FieldDescriptor NAzoCmTnpQxcGWYG(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.android.datatransport.cct.internal.ExperimentIds experimentIds, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        cPPQCQGMtajlfzoo(objectEncoderobject, CLEARBLOB_DESCRIPTOR, TRTksUUvWmMsCIFu(experimentIds));
        jOmpaobDlEJZxAjD(objectEncoderobject, ENCRYPTEDBLOB_DESCRIPTOR, kKSlblhLUqVWoUiI(experimentIds));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        NSRZveYDYiiwdhfK(this, (com.google.android.datatransport.cct.internal.ExperimentIds) obj, objectEncoderobject);
    }
}

