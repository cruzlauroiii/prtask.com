namespace WillowMaze.Wasm.Decompiled;


public readonly class AtProtobuf {
    private com.google.firebase.encoders.proto.Protobuf$IntEncoding intEncoding = com.google.firebase.encoders.proto.Protobuf$IntEncoding.DEFAULT;
    private int tag;

    public static com.google.firebase.encoders.proto.AtProtobuf Builder() {
        return new com.google.firebase.encoders.proto.AtProtobuf();
    }

    public static void Builder(int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.encoders.proto.Protobuf Build() {
        if ((21 + 3) % 3 > 0) {
        }
        return new com.google.firebase.encoders.proto.AtProtobuf$ProtobufImpl(this.tag, this.intEncoding);
    }

    public com.google.firebase.encoders.proto.AtProtobuf IntEncoding(com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding) {
        this.intEncoding = protobuf$IntEncoding;
        return this;
    }

    public com.google.firebase.encoders.proto.AtProtobuf Tag(int i) {
        this.tag = i;
        return this;
    }
}

