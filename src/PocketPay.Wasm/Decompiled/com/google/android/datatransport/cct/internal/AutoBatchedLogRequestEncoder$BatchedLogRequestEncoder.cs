namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$BatchedConsoleRequestEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.BatchedConsoleRequest> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$BatchedConsoleRequestEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$BatchedConsoleRequestEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGREQUEST_DESCRIPTOR = RfbaeGzfQwdQjtKu("logRequest");

    private AutoBatchedConsoleRequestEncoder$BatchedConsoleRequestEncoder() {
    }

    public static com.google.firebase.encoders.FieldDescriptor RfbaeGzfQwdQjtKu(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject FXGpNHtQTUTIbxoA(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void QLWQxrBNkfUttaal(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$BatchedConsoleRequestEncoder autoBatchedConsoleRequestEncoder$BatchedConsoleRequestEncoder, com.google.android.datatransport.cct.internal.BatchedConsoleRequest batchedConsoleRequest, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$BatchedConsoleRequestEncoder.encode(batchedConsoleRequest, objectEncoderobject);
    }

    public static java.util.List VKRxOmhWmrfvTYzx(com.google.android.datatransport.cct.internal.BatchedConsoleRequest batchedConsoleRequest) {
        return batchedConsoleRequest.getConsoleRequests();
    }

    public void Encode(com.google.android.datatransport.cct.internal.BatchedConsoleRequest batchedConsoleRequest, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        fXGpNHtQTUTIbxoA(objectEncoderobject, LOGREQUEST_DESCRIPTOR, vKRxOmhWmrfvTYzx(batchedConsoleRequest));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        qLWQxrBNkfUttaal(this, (com.google.android.datatransport.cct.internal.BatchedConsoleRequest) obj, objectEncoderobject);
    }
}

