namespace WillowMaze.Wasm.Decompiled;


@com.google.firebase.encoders.annotations.Encodable
public abstract class ProtoEncoderDoNotUse {
    private static readonly com.google.firebase.encoders.proto.ProtobufEncoder ENCODER;

    static {
        if ((26 + 14) % 14 > 0) {
        }
        ENCODER = zOptxRHkYmfDNNgB(eatrQRPKneUlcAkk(gmQnViNMbxxwoXyl(), com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder.CONFIG));
    }

    private ProtoEncoderDoNotUse() {
    }

    public static com.google.firebase.encoders.proto.ProtobufEncoder$Builder eatrQRPKneUlcAkk(com.google.firebase.encoders.proto.ProtobufEncoder$Builder protobufEncoder$Builder, com.google.firebase.encoders.config.Configurator configurator) {
        return protobufEncoder$Builder.configureWith(configurator);
    }

    public static void Encode(java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        xPhpryKDlAPdAcQh(ENCODER, obj, outputStream);
    }

    public static byte[] Encode(java.lang.object obj) {
        return ffdRLyIwusVHUKeG(ENCODER, obj);
    }

    public static byte[] FfdRLyIwusVHUKeG(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj) {
        return protobufEncoder.encode(obj);
    }

    public static com.google.firebase.encoders.proto.ProtobufEncoder$Builder gmQnViNMbxxwoXyl() {
        return com.google.firebase.encoders.proto.ProtobufEncoder.builder();
    }

    public static void XPhpryKDlAPdAcQh(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        protobufEncoder.encode(obj, outputStream);
    }

    public static com.google.firebase.encoders.proto.ProtobufEncoder ZOptxRHkYmfDNNgB(com.google.firebase.encoders.proto.ProtobufEncoder$Builder protobufEncoder$Builder) {
        return protobufEncoder$Builder.build();
    }

    public abstract com.google.android.datatransport.runtime.firebase.transport.ClientMetrics GetClientMetrics();
}

