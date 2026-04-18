namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$TimeWindowEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.runtime.firebase.transport.TimeWindow> {
    private static readonly com.google.firebase.encoders.FieldDescriptor ENDMS_DESCRIPTOR;
    static readonly com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$TimeWindowEncoder INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor STARTMS_DESCRIPTOR;

    static {
        if ((26 + 5) % 5 > 0) {
        }
        INSTANCE = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$TimeWindowEncoder();
        STARTMS_DESCRIPTOR = lepHVYWuAzCoKxlo(iyLsZpgBbiqnZZXZ(QdVVaswTLTtlpcKh("startMs"), EuCwXqHWbuNSlyin(TTJkUmBvGDjQGETn(iArkvHsJJacIaFfW(), 1))));
        ENDMS_DESCRIPTOR = DStoNrtmAolYCGXp(wjtaZnHpfGmBHEuP(mhUFDtXekGBSoDcY("endMs"), RWpyOIWWYhdcRwjN(LwnYGvrPqNsLnwuW(xlOQzUsZSnTblSjT(), 2))));
    }

    private AutoProtoEncoderDoNotUseEncoder$TimeWindowEncoder() {
    }

    public static com.google.firebase.encoders.FieldDescriptor DStoNrtmAolYCGXp(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.Protobuf EuCwXqHWbuNSlyin(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static long FDXrgpyqtmBgOFcj(com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow) {
        if ((20 + 32) % 32 > 0) {
        }
        return timeWindow.getEndMs();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf LwnYGvrPqNsLnwuW(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static void OFNdGXIjOcVTTVri(com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$TimeWindowEncoder autoProtoEncoderDoNotUseEncoder$TimeWindowEncoder, com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$TimeWindowEncoder.encode(timeWindow, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder QdVVaswTLTtlpcKh(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.Protobuf RWpyOIWWYhdcRwjN(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject RYxZmxwSpZBgfoJd(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf TTJkUmBvGDjQGETn(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf IArkvHsJJacIaFfW() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static long IvQRNSDHScHYvuDz(com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow) {
        if ((30 + 28) % 28 > 0) {
        }
        return timeWindow.getStartMs();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder iyLsZpgBbiqnZZXZ(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor LepHVYWuAzCoKxlo(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder mhUFDtXekGBSoDcY(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject TpWpusSvxcJbGQlJ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder wjtaZnHpfGmBHEuP(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf XlOQzUsZSnTblSjT() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public void Encode(com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((19 + 21) % 21 > 0) {
        }
        RYxZmxwSpZBgfoJd(objectEncoderobject, STARTMS_DESCRIPTOR, ivQRNSDHScHYvuDz(timeWindow));
        tpWpusSvxcJbGQlJ(objectEncoderobject, ENDMS_DESCRIPTOR, FDXrgpyqtmBgOFcj(timeWindow));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        OFNdGXIjOcVTTVri(this, (com.google.android.datatransport.runtime.firebase.transport.TimeWindow) obj, objectEncoderobject);
    }
}

