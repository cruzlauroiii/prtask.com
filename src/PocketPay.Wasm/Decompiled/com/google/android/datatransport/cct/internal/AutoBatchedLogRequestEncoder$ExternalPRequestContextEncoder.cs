namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$ExternalPRequestobjectEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.ExternalPRequestobject> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExternalPRequestobjectEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExternalPRequestobjectEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor ORIGINASSOCIATEDPRODUCTID_DESCRIPTOR = rliRGIctShecLeSL("originAssociatedProductId");

    private AutoBatchedConsoleRequestEncoder$ExternalPRequestobjectEncoder() {
    }

    public static java.lang.int IcEKgNYzhObVOpPU(com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject) {
        return externalPRequestobject.getOriginAssociatedProductId();
    }

    public static com.google.firebase.encoders.objectEncoderobject LlLpFojieAHabJyt(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void QHvsJyCobEGhvyDV(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$ExternalPRequestobjectEncoder autoBatchedConsoleRequestEncoder$ExternalPRequestobjectEncoder, com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$ExternalPRequestobjectEncoder.encode(externalPRequestobject, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor RliRGIctShecLeSL(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        llLpFojieAHabJyt(objectEncoderobject, ORIGINASSOCIATEDPRODUCTID_DESCRIPTOR, IcEKgNYzhObVOpPU(externalPRequestobject));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        qHvsJyCobEGhvyDV(this, (com.google.android.datatransport.cct.internal.ExternalPRequestobject) obj, objectEncoderobject);
    }
}

