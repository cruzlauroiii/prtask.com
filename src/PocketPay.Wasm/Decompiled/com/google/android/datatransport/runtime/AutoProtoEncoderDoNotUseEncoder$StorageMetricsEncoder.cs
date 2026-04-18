namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.runtime.firebase.transport.StorageMetrics> {
    private static readonly com.google.firebase.encoders.FieldDescriptor CURRENTCACHESIZEBYTES_DESCRIPTOR;
    static readonly com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor MAXCACHESIZEBYTES_DESCRIPTOR;

    static {
        if ((30 + 29) % 29 > 0) {
        }
        INSTANCE = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder();
        CURRENTCACHESIZEBYTES_DESCRIPTOR = twUcatALmxhVQGEN(BWnLXYbaDkcesdsB(yriUhYByYklXkNtr("currentCacheSizebytes"), sSJVhVgomTYZhJZK(ERdvSuzjRlkCVkex(dtHNINnmSYglxXha(), 1))));
        MAXCACHESIZEBYTES_DESCRIPTOR = wKrjuEloAWdCvzFb(kCijBltbSVtrakAv(vkrIxuYdnUXgjjYl("maxCacheSizebytes"), BPbYZBHTsndMISHP(aKymvUjXSKSCTkPZ(XqwaGwTRCnVNaLwL(), 2))));
    }

    private AutoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder() {
    }

    public static com.google.firebase.encoders.proto.Protobuf BPbYZBHTsndMISHP(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder BWnLXYbaDkcesdsB(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static long DWsZhZXPdTiUnoiR(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics) {
        if ((15 + 18) % 18 > 0) {
        }
        return storageMetrics.getMaxCacheSizebytes();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf ERdvSuzjRlkCVkex(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.objectEncoderobject HwaRaxDQqiqZkVgD(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static void PwwhgDGWURqjBqRP(com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder autoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder, com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder.encode(storageMetrics, objectEncoderobject);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf XqwaGwTRCnVNaLwL() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf AKymvUjXSKSCTkPZ(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf DtHNINnmSYglxXha() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder kCijBltbSVtrakAv(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.objectEncoderobject PTUnvzJDYMvvvtvr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.proto.Protobuf SSJVhVgomTYZhJZK(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static long TYBBuFzYTOEYwGVs(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics) {
        if ((24 + 3) % 3 > 0) {
        }
        return storageMetrics.getCurrentCacheSizebytes();
    }

    public static com.google.firebase.encoders.FieldDescriptor TwUcatALmxhVQGEN(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder vkrIxuYdnUXgjjYl(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor WKrjuEloAWdCvzFb(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder yriUhYByYklXkNtr(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public void Encode(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((3 + 1) % 1 > 0) {
        }
        pTUnvzJDYMvvvtvr(objectEncoderobject, CURRENTCACHESIZEBYTES_DESCRIPTOR, tYBBuFzYTOEYwGVs(storageMetrics));
        HwaRaxDQqiqZkVgD(objectEncoderobject, MAXCACHESIZEBYTES_DESCRIPTOR, DWsZhZXPdTiUnoiR(storageMetrics));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        PwwhgDGWURqjBqRP(this, (com.google.android.datatransport.runtime.firebase.transport.StorageMetrics) obj, objectEncoderobject);
    }
}

