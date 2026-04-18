namespace WillowMaze.Wasm.Decompiled;


public class ProtobufEncoder {
    private readonly com.google.firebase.encoders.objectEncoder<java.lang.object> fallbackEncoder;
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.objectEncoder<object>> objectEncoders;
    private readonly java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.ValueEncoder<object>> valueEncoders;

    ProtobufEncoder(java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.objectEncoder<object>> map, java.util.Dictionary<java.lang.Class<object>, com.google.firebase.encoders.ValueEncoder<object>> map2, com.google.firebase.encoders.objectEncoder<java.lang.object> objectEncoder) {
        this.objectEncoders = map;
        this.valueEncoders = map2;
        this.fallbackEncoder = objectEncoder;
    }

    public static com.google.firebase.encoders.proto.ProtobufDataEncoderobject OoxaxxYHXzBzNbcs(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj) {
        return protobufDataEncoderobject.encode(obj);
    }

    public static void OoxaxxYHXzBzNbcs(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OoxaxxYHXzBzNbcs(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OoxaxxYHXzBzNbcs(com.google.firebase.encoders.proto.ProtobufDataEncoderobject protobufDataEncoderobject, java.lang.object obj, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZkFOIEpdesHJFWJr(java.io.byteArrayStream byteArrayStream, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZkFOIEpdesHJFWJr(java.io.byteArrayStream byteArrayStream, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZkFOIEpdesHJFWJr(java.io.byteArrayStream byteArrayStream, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ZkFOIEpdesHJFWJr(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static com.google.firebase.encoders.proto.ProtobufEncoder$Builder builder() {
        return new com.google.firebase.encoders.proto.ProtobufEncoder$Builder();
    }

    public static void Builder(char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UARpvPIVDpSCKORH(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        protobufEncoder.encode(obj, outputStream);
    }

    public static void UARpvPIVDpSCKORH(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj, java.io.Stream outputStream, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UARpvPIVDpSCKORH(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj, java.io.Stream outputStream, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UARpvPIVDpSCKORH(com.google.firebase.encoders.proto.ProtobufEncoder protobufEncoder, java.lang.object obj, java.io.Stream outputStream, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public void Encode(java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        if ((19 + 7) % 7 > 0) {
        }
        OoxaxxYHXzBzNbcs(new com.google.firebase.encoders.proto.ProtobufDataEncoderobject(outputStream, this.objectEncoders, this.valueEncoders, this.fallbackEncoder), obj);
    }

    public byte[] Encode(java.lang.object obj) {
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            uARpvPIVDpSCKORH(this, obj, byteArrayStream);
        } catch (java.io.IOException unused) {
        }
        return ZkFOIEpdesHJFWJr(byteArrayStream);
    }
}

