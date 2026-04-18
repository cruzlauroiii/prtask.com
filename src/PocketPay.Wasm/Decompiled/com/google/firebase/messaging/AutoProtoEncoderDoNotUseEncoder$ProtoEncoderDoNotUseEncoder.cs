namespace WillowMaze.Wasm.Decompiled;


readonly class AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.messaging.ProtoEncoderDoNotUse> {
    static readonly com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder INSTANCE = new com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor MESSAGINGCLIENTEVENTEXTENSION_DESCRIPTOR = sqwOWuPFajsrmhvK("messagingClientEventExtension");

    private AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder() {
    }

    public static void BuTfvgpZGrmafvMN(com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder autoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder, com.google.firebase.messaging.ProtoEncoderDoNotUse protoEncoderDoNotUse, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder.encode(protoEncoderDoNotUse, objectEncoderobject);
    }

    public static com.google.firebase.encoders.objectEncoderobject HwobNsixwoZmjPdN(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEventExtension WsUhgexDIwuQyKuC(com.google.firebase.messaging.ProtoEncoderDoNotUse protoEncoderDoNotUse) {
        return protoEncoderDoNotUse.getMessagingClientEventExtension();
    }

    public static com.google.firebase.encoders.FieldDescriptor SqwOWuPFajsrmhvK(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.firebase.messaging.ProtoEncoderDoNotUse protoEncoderDoNotUse, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        HwobNsixwoZmjPdN(objectEncoderobject, MESSAGINGCLIENTEVENTEXTENSION_DESCRIPTOR, WsUhgexDIwuQyKuC(protoEncoderDoNotUse));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        BuTfvgpZGrmafvMN(this, (com.google.firebase.messaging.ProtoEncoderDoNotUse) obj, objectEncoderobject);
    }
}

