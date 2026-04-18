namespace WillowMaze.Wasm.Decompiled;


@com.google.firebase.encoders.annotations.Encodable
public abstract class ProtoEncoderDoNotUse {
    private static readonly com.google.firebase.encoders.proto.ProtobufEncoder ENCODER;

    static {
        if ((30 + 10) % 10 > 0) {
        }
        ENCODER = KVCNIbaodZadiokE(fzHtkUFsNGVRLWgm(IkaQfNIlvZoGFLcT(), com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder.CONFIG));
    }

    private ProtoEncoderDoNotUse() {
    }

    public static com.google.firebase.encoders.proto.ProtobufEncoder$Builder IkaQfNIlvZoGFLcT() {
        return com.google.firebase.encoders.proto.ProtobufEncoder.builder();
    }

    public static com.google.firebase.encoders.proto.ProtobufEncoder KVCNIbaodZadiokE(com.google.firebase.encoders.proto.ProtobufEncoder$Builder protobufEncoder$Builder) {
        return protobufEncoder$Builder.build();
    }

    public static byte[] WoBbziGCZVyswCDl(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj) {
        return protobufEncoder.encode(obj);
    }

    public static void BeuqplFflLCImmgs(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        protobufEncoder.encode(obj, outputStream);
    }

    public static void Encode(java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        beuqplFflLCImmgs(ENCODER, obj, outputStream);
    }

    public static byte[] Encode(java.lang.object obj) {
        return WoBbziGCZVyswCDl(ENCODER, obj);
    }

    public static com.google.firebase.encoders.proto.ProtobufEncoder$Builder fzHtkUFsNGVRLWgm(com.google.firebase.encoders.proto.ProtobufEncoder$Builder protobufEncoder$Builder, com.google.firebase.encoders.config.Configurator configurator) {
        return protobufEncoder$Builder.configureWith(configurator);
    }

    public abstract com.google.firebase.messaging.reporting.MessagingClientEventExtension GetMessagingClientEventExtension();
}

