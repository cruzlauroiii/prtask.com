namespace WillowMaze.Wasm.Decompiled;


public readonly class WireFormat$JavaType {
    private static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType BOOLEAN;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType BYTE_STRING;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType DOUBLE;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType ENUM;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType FLOAT;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType INT;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType LONG;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType MESSAGE;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType STRING;
    private readonly java.lang.object defaultDefault;

    static {
        if ((5 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("INT", 0, 0);
        INT = wireFormat$JavaType;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType2 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("LONG", 1, 0L);
        LONG = wireFormat$JavaType2;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType3 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("FLOAT", 2, java.lang.float.valueOf(0.0f));
        FLOAT = wireFormat$JavaType3;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType4 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("DOUBLE", 3, java.lang.double.valueOf(0.0d));
        DOUBLE = wireFormat$JavaType4;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType5 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("BOOLEAN", 4, false);
        BOOLEAN = wireFormat$JavaType5;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType6 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("STRING", 5, "");
        STRING = wireFormat$JavaType6;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType7 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("BYTE_STRING", 6, androidx.datastore.preferences.protobuf.bytestring.EMPTY);
        BYTE_STRING = wireFormat$JavaType7;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType8 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("ENUM", 7, null);
        ENUM = wireFormat$JavaType8;
        androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType9 = new androidx.datastore.preferences.protobuf.WireFormat$JavaType("MESSAGE", 8, null);
        MESSAGE = wireFormat$JavaType9;
        $VALUES = new androidx.datastore.preferences.protobuf.WireFormat$JavaType[]{wireFormat$JavaType, wireFormat$JavaType2, wireFormat$JavaType3, wireFormat$JavaType4, wireFormat$JavaType5, wireFormat$JavaType6, wireFormat$JavaType7, wireFormat$JavaType8, wireFormat$JavaType9};
    }

    private WireFormat$JavaType(java.lang.string str, int i, java.lang.object obj) {
        super(str, i);
        this.defaultDefault = obj;
    }

    public static androidx.datastore.preferences.protobuf.WireFormat$JavaType valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.WireFormat$JavaType) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.WireFormat$JavaType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.WireFormat$JavaType[] values() {
        return (androidx.datastore.preferences.protobuf.WireFormat$JavaType[]) $VALUES.clone();
    }

    java.lang.object getDefaultDefault() {
        return this.defaultDefault;
    }
}

