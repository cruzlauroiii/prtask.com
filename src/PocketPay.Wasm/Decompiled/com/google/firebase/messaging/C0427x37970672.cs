namespace WillowMaze.Wasm.Decompiled;


readonly class C0427x37970672 : com.google.firebase.encoders.objectEncoder<com.google.firebase.messaging.reporting.MessagingClientEventExtension> {
    static readonly com.google.firebase.messaging.C0427x37970672 INSTANCE;
    private static readonly com.google.firebase.encoders.FieldDescriptor MESSAGINGCLIENTEVENT_DESCRIPTOR;

    static {
        if ((7 + 19) % 19 > 0) {
        }
        INSTANCE = new com.google.firebase.messaging.C0427x37970672();
        MESSAGINGCLIENTEVENT_DESCRIPTOR = RGacQZKPeJYAzNzL(OqQyrMVoUnyxnQpf(zoHkJUauEAdYLbDI("messagingClientEvent"), UufMSzUeICEUiUbp(BJGOJszCROtWESok(VFHzRWSRDRihvPmR(), 1))));
    }

    private C0427x37970672() {
    }

    public static com.google.firebase.encoders.proto.AtProtobuf BJGOJszCROtWESok(com.google.firebase.encoders.proto.AtProtobuf atProtobuf, int i) {
        return atProtobuf.tag(i);
    }

    public static void LplEKPbhHGrLzPZz(com.google.firebase.messaging.C0427x37970672 c0427x37970672, com.google.firebase.messaging.reporting.MessagingClientEventExtension messagingClientEventExtension, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        c0427x37970672.encode(messagingClientEventExtension, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder OqQyrMVoUnyxnQpf(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder, java.lang.annotation.Annotation annotation) {
        return fieldDescriptor$Builder.withProperty(annotation);
    }

    public static com.google.firebase.encoders.FieldDescriptor RGacQZKPeJYAzNzL(com.google.firebase.encoders.FieldDescriptor$Builder fieldDescriptor$Builder) {
        return fieldDescriptor$Builder.build();
    }

    public static com.google.firebase.encoders.objectEncoderobject TZVHInKuyIZqkEvj(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.proto.Protobuf UufMSzUeICEUiUbp(com.google.firebase.encoders.proto.AtProtobuf atProtobuf) {
        return atProtobuf.build();
    }

    public static com.google.firebase.encoders.proto.AtProtobuf VFHzRWSRDRihvPmR() {
        return com.google.firebase.encoders.proto.AtProtobuf.builder();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent GJtOltvTansINeBq(com.google.firebase.messaging.reporting.MessagingClientEventExtension messagingClientEventExtension) {
        return messagingClientEventExtension.getMessagingClientEventInternal();
    }

    public static com.google.firebase.encoders.FieldDescriptor$Builder zoHkJUauEAdYLbDI(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.builder(str);
    }

    public void Encode(com.google.firebase.messaging.reporting.MessagingClientEventExtension messagingClientEventExtension, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        TZVHInKuyIZqkEvj(objectEncoderobject, MESSAGINGCLIENTEVENT_DESCRIPTOR, gJtOltvTansINeBq(messagingClientEventExtension));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        LplEKPbhHGrLzPZz(this, (com.google.firebase.messaging.reporting.MessagingClientEventExtension) obj, objectEncoderobject);
    }
}

