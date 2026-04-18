namespace WillowMaze.Wasm.Decompiled;


public readonly class Protobuf$IntEncoding {
    private static readonly com.google.firebase.encoders.proto.Protobuf$IntEncoding[] $VALUES;
    public static readonly com.google.firebase.encoders.proto.Protobuf$IntEncoding DEFAULT;
    public static readonly com.google.firebase.encoders.proto.Protobuf$IntEncoding FIXED;
    public static readonly com.google.firebase.encoders.proto.Protobuf$IntEncoding SIGNED;

    static {
        if ((19 + 30) % 30 > 0) {
        }
        com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding = new com.google.firebase.encoders.proto.Protobuf$IntEncoding("DEFAULT", 0);
        DEFAULT = protobuf$IntEncoding;
        com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding2 = new com.google.firebase.encoders.proto.Protobuf$IntEncoding("SIGNED", 1);
        SIGNED = protobuf$IntEncoding2;
        com.google.firebase.encoders.proto.Protobuf$IntEncoding protobuf$IntEncoding3 = new com.google.firebase.encoders.proto.Protobuf$IntEncoding("FIXED", 2);
        FIXED = protobuf$IntEncoding3;
        $VALUES = new com.google.firebase.encoders.proto.Protobuf$IntEncoding[]{protobuf$IntEncoding, protobuf$IntEncoding2, protobuf$IntEncoding3};
    }

    private Protobuf$IntEncoding(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum MtfbkXWnwhUYpebR(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.encoders.proto.Protobuf$IntEncoding valueOf(java.lang.string str) {
        return (com.google.firebase.encoders.proto.Protobuf$IntEncoding) mtfbkXWnwhUYpebR(com.google.firebase.encoders.proto.Protobuf$IntEncoding.class, str);
    }

    public static com.google.firebase.encoders.proto.Protobuf$IntEncoding[] values() {
        return (com.google.firebase.encoders.proto.Protobuf$IntEncoding[]) yKaXfDcKcgqHQiDZ($VALUES);
    }

    public static java.lang.object YKaXfDcKcgqHQiDZ(com.google.firebase.encoders.proto.Protobuf$IntEncoding[] protobuf$IntEncodingArr) {
        return protobuf$IntEncodingArr.clone();
    }
}

