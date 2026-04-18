namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics> {
    static readonly com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor STORAGEMETRICS_DESCRIPTOR;

    static {
        if ((12 + 17) % 17 > 0) {
        }
        INSTANCE = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder();
        STORAGEMETRICS_DESCRIPTOR = xfdkDiINqokSRMto(xJPVYCbLigDKKbTb(NzsBiaFFBcPqcHrC("storageMetrics"), dbinUWBmHQqWLBBG(TJgQszmOykqrZqeQ(EsGRQzDineFNvplh(), 1))));
    }

    private AutoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder() {
    }

    public static com.google.firebase.encoders.proto.AtProtobuf EsGRQzDineFNvplh() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder NzsBiaFFBcPqcHrC(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject ONaiSloZjCPNQACr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void RBOYcrXVXGDDMPnp(com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder autoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder, com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics globalMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder.encode(globalMetrics, objectEncoderobject);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf TJgQszmOykqrZqeQ(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics UwYRgzonTfUABfAA(com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics globalMetrics) {
        return globalMetrics.getStorageMetricsInternal();
    }

    public static com.google.firebase.encoders.proto.Protobuf DbinUWBmHQqWLBBG(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder xJPVYCbLigDKKbTb(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor XfdkDiINqokSRMto(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public void Encode(com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics globalMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        ONaiSloZjCPNQACr(objectEncoderobject, STORAGEMETRICS_DESCRIPTOR, UwYRgzonTfUABfAA(globalMetrics));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        RBOYcrXVXGDDMPnp(this, (com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics) obj, objectEncoderobject);
    }
}

