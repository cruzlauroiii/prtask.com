namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.runtime.ProtoEncoderDoNotUse> {
    static readonly com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder INSTANCE = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor CLIENTMETRICS_DESCRIPTOR = JuxoJOrytJnBLDat("clientMetrics");

    private AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder() {
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics CyGcTjPRrJROPvqM(com.google.android.datatransport.runtime.ProtoEncoderDoNotUse protoEncoderDoNotUse) {
        return protoEncoderDoNotUse.getClientMetrics();
    }

    public static void IzEGfAXweoAJyRjH(com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder autoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder, com.google.android.datatransport.runtime.ProtoEncoderDoNotUse protoEncoderDoNotUse, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder.encode(protoEncoderDoNotUse, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor JuxoJOrytJnBLDat(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject LxGSqpMKLDczNjEA(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public void Encode(com.google.android.datatransport.runtime.ProtoEncoderDoNotUse protoEncoderDoNotUse, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        LxGSqpMKLDczNjEA(objectEncoderobject, CLIENTMETRICS_DESCRIPTOR, CyGcTjPRrJROPvqM(protoEncoderDoNotUse));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        IzEGfAXweoAJyRjH(this, (com.google.android.datatransport.runtime.ProtoEncoderDoNotUse) obj, objectEncoderobject);
    }
}

