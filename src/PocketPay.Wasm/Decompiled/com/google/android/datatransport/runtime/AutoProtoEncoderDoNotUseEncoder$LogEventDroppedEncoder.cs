namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped> {
    private static readonly com.google.firebase.encoders.FieldDescriptor EVENTSDROPPEDCOUNT_DESCRIPTOR;
    static readonly com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor REASON_DESCRIPTOR;

    static {
        if ((26 + 25) % 25 > 0) {
        }
        INSTANCE = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder();
        EVENTSDROPPEDCOUNT_DESCRIPTOR = DaeOybigBjCSeGMa(NwPIkWuZJbpEzchF(HJHfEPvFVVqTeUYB("eventsDroppedCount"), dDLQQqbnzPyTylcu(tdGxJydFWcqMvOdE(UlJlWOHDeJQaYzIY(), 1))));
        REASON_DESCRIPTOR = lVlvBspqwnPpQuJz(zknYieDtIxOuADew(OBGCjHJFAkVkjEWG("reason"), FbKYYBArnTYBKEMx(azcFjqaIVmmdIFLp(qvZADwYgdaUIaxBI(), 3))));
    }

    private AutoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder() {
    }

    public static com.google.firebase.encoders.FieldDescriptor DaeOybigBjCSeGMa(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.Protobuf FbKYYBArnTYBKEMx(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder HJHfEPvFVVqTeUYB(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static void NrwpeWzqleqeikSO(com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder autoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped logEventDropped, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder.encode(logEventDropped, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder NwPIkWuZJbpEzchF(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder OBGCjHJFAkVkjEWG(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf UlJlWOHDeJQaYzIY() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.encoders.objectEncoderobject ZzbWULpPRuTanTOv(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.AtProtobuf AzcFjqaIVmmdIFLp(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.proto.Protobuf DDLQQqbnzPyTylcu(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject HKMTnuwbYdUmyTLP(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason itbjkYeBpsCReYsv(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped logEventDropped) {
        return logEventDropped.getReason();
    }

    public static com.google.firebase.encoders.FieldDescriptor LVlvBspqwnPpQuJz(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf QvZADwYgdaUIaxBI() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static long RhiNtEwogvtJGHOz(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped logEventDropped) {
        if ((31 + 7) % 7 > 0) {
        }
        return logEventDropped.getEventsDroppedCount();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf TdGxJydFWcqMvOdE(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder zknYieDtIxOuADew(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public void Encode(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped logEventDropped, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((19 + 16) % 16 > 0) {
        }
        hKMTnuwbYdUmyTLP(objectEncoderobject, EVENTSDROPPEDCOUNT_DESCRIPTOR, rhiNtEwogvtJGHOz(logEventDropped));
        ZzbWULpPRuTanTOv(objectEncoderobject, REASON_DESCRIPTOR, itbjkYeBpsCReYsv(logEventDropped));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        NrwpeWzqleqeikSO(this, (com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped) obj, objectEncoderobject);
    }
}

