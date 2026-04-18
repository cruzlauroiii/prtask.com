namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.runtime.firebase.transport.ClientMetrics> {
    private static readonly com.google.firebase.encoders.FieldDescriptor APPNAMESPACE_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor GLOBALMETRICS_DESCRIPTOR;
    static readonly com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGSOURCEMETRICS_DESCRIPTOR;
    private static readonly com.google.firebase.encoders.FieldDescriptor WINDOW_DESCRIPTOR;

    static {
        if ((10 + 22) % 22 > 0) {
        }
        INSTANCE = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder();
        WINDOW_DESCRIPTOR = LeZGsPZBgMrFcWEx(yCUWfUiFGQILywyu(vEvSpOOOPLYlFbWY("window"), idSAAtvyCjYgKxEx(qcikrcOZhfKfASEH(rCEupjyqUVkCinjI(), 1))));
        LOGSOURCEMETRICS_DESCRIPTOR = joFQuIkyFRwAZzqQ(ZctAaLLtSFtIKabu(kFOtMpiYCXORDzku("logSourceMetrics"), OIrlbouigXrJarao(qApYjCqHuziOxLHi(VyeUIWpbAUeKXnlk(), 2))));
        GLOBALMETRICS_DESCRIPTOR = hIxfnnDauTBbVamP(GQUfpZQBfsupYjro(HGBwodIQJJicJsty("globalMetrics"), uBPnPthWkBbPcdjF(TjKPTiRkIazZxjWj(PbALvWXcaDOLiMAB(), 3))));
        APPNAMESPACE_DESCRIPTOR = AyvalZaGYdWxYmcb(vZoNhErEXMJKFkdH(KmVZVDuEitDJMbQr("appNamespace"), dmDzUYuOiUqKEiyV(VWwvpespVsDnpSlN(NQiYoHMsouiiKAzF(), 4))));
    }

    private AutoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder() {
    }

    public static com.google.firebase.encoders.FieldDescriptor AyvalZaGYdWxYmcb(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject BikisNyktAGZjnNS(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.util.List ERAWxIAkKEyYYMmt(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics clientMetrics) {
        return clientMetrics.getConsoleSourceMetricsList();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder GQUfpZQBfsupYjro(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder HGBwodIQJJicJsty(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject IdcSxBFkgTkOgKFu(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder KmVZVDuEitDJMbQr(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor LeZGsPZBgMrFcWEx(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf NQiYoHMsouiiKAzF() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.Protobuf OIrlbouigXrJarao(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf PbALvWXcaDOLiMAB() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf TjKPTiRkIazZxjWj(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.objectEncoderobject TpRCvhDUXickGWzB(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf VWwvpespVsDnpSlN(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf VyeUIWpbAUeKXnlk() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder ZctAaLLtSFtIKabu(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.objectEncoderobject ARIeeHLjbGvSUZtQ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.Protobuf DmDzUYuOiUqKEiyV(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor HIxfnnDauTBbVamP(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.Protobuf IdSAAtvyCjYgKxEx(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor JoFQuIkyFRwAZzqQ(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder kFOtMpiYCXORDzku(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf QApYjCqHuziOxLHi(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf QcikrcOZhfKfASEH(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf RCEupjyqUVkCinjI() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static java.lang.string SCKLuQPDFZtPFGJF(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics clientMetrics) {
        return clientMetrics.getAppNamespace();
    }

    public static void SYYVzhhxyIDNZSaA(com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder autoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics clientMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder.encode(clientMetrics, objectEncoderobject);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow TBRCzAQbasCHNPld(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics clientMetrics) {
        return clientMetrics.getWindowInternal();
    }

    public static com.google.firebase.encoders.proto.Protobuf UBPnPthWkBbPcdjF(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics UcZLEmbdJDCsjnOJ(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics clientMetrics) {
        return clientMetrics.getGlobalMetricsInternal();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder vEvSpOOOPLYlFbWY(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder vZoNhErEXMJKFkdH(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder yCUWfUiFGQILywyu(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public void Encode(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics clientMetrics, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        aRIeeHLjbGvSUZtQ(objectEncoderobject, WINDOW_DESCRIPTOR, tBRCzAQbasCHNPld(clientMetrics));
        TpRCvhDUXickGWzB(objectEncoderobject, LOGSOURCEMETRICS_DESCRIPTOR, ERAWxIAkKEyYYMmt(clientMetrics));
        IdcSxBFkgTkOgKFu(objectEncoderobject, GLOBALMETRICS_DESCRIPTOR, ucZLEmbdJDCsjnOJ(clientMetrics));
        BikisNyktAGZjnNS(objectEncoderobject, APPNAMESPACE_DESCRIPTOR, sCKLuQPDFZtPFGJF(clientMetrics));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        sYYVzhhxyIDNZSaA(this, (com.google.android.datatransport.runtime.firebase.transport.ClientMetrics) obj, objectEncoderobject);
    }
}

