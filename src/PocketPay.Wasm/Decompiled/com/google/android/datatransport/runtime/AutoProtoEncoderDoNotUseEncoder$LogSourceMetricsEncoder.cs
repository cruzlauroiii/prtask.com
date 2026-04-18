namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics> {
    static readonly com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGEVENTDROPPED_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGSOURCE_DESCRIPTOR;

    static {
        if ((6 + 32) % 32 > 0) {
        }
        INSTANCE = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder();
        LOGSOURCE_DESCRIPTOR = fSjsOqLooCbhwxGJ(STpzGRXcsxmiCJcm(ujDItyMsmpEzqofw("logSource"), NBJVbXQtSqrvsVyH(eLRCXIzlaecLTVrK(ZgQEmOZJdhiNkAhl(), 1))));
        LOGEVENTDROPPED_DESCRIPTOR = vKHnONnMDwRSCASi(OZvupoVQHCeaaxfr(OpynnBjbDDYjlEyz("logEventDropped"), WMfCndPldBgNXuFV(USxXkWCejjAPqBAX(bUkdFJGDZbyfxxRU(), 2))));
    }

    private AutoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder() {
    }

    public static com.google.firebase.encoders.proto.Protobuf NBJVbXQtSqrvsVyH(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder OZvupoVQHCeaaxfr(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder OpynnBjbDDYjlEyz(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder STpzGRXcsxmiCJcm(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf USxXkWCejjAPqBAX(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.objectEncoderobject UVsMhdZVIFsTXYOo(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.Protobuf WMfCndPldBgNXuFV(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject XzNXRvwaBdRQKGfQ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void ZFUXkCEBbHGEROkE(com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder autoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder, com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics logSourceMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder.encode(logSourceMetrics, objectEncoderobject);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf ZgQEmOZJdhiNkAhl() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf BUkdFJGDZbyfxxRU() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf ELRCXIzlaecLTVrK(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.FieldDescriptor FSjsOqLooCbhwxGJ(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static java.util.List LCJYKZXVRLLVPQzh(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics logSourceMetrics) {
        return logSourceMetrics.getConsoleEventDroppedList();
    }

    public static java.lang.string PgFudzjjGdrjRWhL(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics logSourceMetrics) {
        return logSourceMetrics.getConsoleSource();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder ujDItyMsmpEzqofw(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor VKHnONnMDwRSCASi(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public void Encode(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics logSourceMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        UVsMhdZVIFsTXYOo(objectEncoderobject, LOGSOURCE_DESCRIPTOR, pgFudzjjGdrjRWhL(logSourceMetrics));
        XzNXRvwaBdRQKGfQ(objectEncoderobject, LOGEVENTDROPPED_DESCRIPTOR, lCJYKZXVRLLVPQzh(logSourceMetrics));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        ZFUXkCEBbHGEROkE(this, (com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics) obj, objectEncoderobject);
    }
}

