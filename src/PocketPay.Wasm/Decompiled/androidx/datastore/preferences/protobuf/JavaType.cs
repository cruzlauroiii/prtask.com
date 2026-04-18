namespace WillowMaze.Wasm.Decompiled;


public readonly class JavaType {
    private static readonly androidx.datastore.preferences.protobuf.JavaType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.JavaType BOOLEAN;
    public static readonly androidx.datastore.preferences.protobuf.JavaType BYTE_STRING;
    public static readonly androidx.datastore.preferences.protobuf.JavaType DOUBLE;
    public static readonly androidx.datastore.preferences.protobuf.JavaType ENUM;
    public static readonly androidx.datastore.preferences.protobuf.JavaType FLOAT;
    public static readonly androidx.datastore.preferences.protobuf.JavaType INT;
    public static readonly androidx.datastore.preferences.protobuf.JavaType LONG;
    public static readonly androidx.datastore.preferences.protobuf.JavaType MESSAGE;
    public static readonly androidx.datastore.preferences.protobuf.JavaType STRING;
    public static readonly androidx.datastore.preferences.protobuf.JavaType VOID;
    private readonly java.lang.Class<object> boxedType;
    private readonly java.lang.object defaultDefault;
    private readonly java.lang.Class<object> type;

    static {
        if ((25 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.JavaType javaType = new androidx.datastore.preferences.protobuf.JavaType("VOID", 0, java.lang.void.class, java.lang.void.class, null);
        VOID = javaType;
        androidx.datastore.preferences.protobuf.JavaType javaType2 = new androidx.datastore.preferences.protobuf.JavaType("INT", 1, java.lang.int.TYPE, java.lang.int.class, 0);
        INT = javaType2;
        androidx.datastore.preferences.protobuf.JavaType javaType3 = new androidx.datastore.preferences.protobuf.JavaType("LONG", 2, java.lang.long.TYPE, java.lang.long.class, 0L);
        LONG = javaType3;
        androidx.datastore.preferences.protobuf.JavaType javaType4 = new androidx.datastore.preferences.protobuf.JavaType("FLOAT", 3, java.lang.float.TYPE, java.lang.float.class, java.lang.float.valueOf(0.0f));
        FLOAT = javaType4;
        androidx.datastore.preferences.protobuf.JavaType javaType5 = new androidx.datastore.preferences.protobuf.JavaType("DOUBLE", 4, java.lang.double.TYPE, java.lang.double.class, java.lang.double.valueOf(0.0d));
        DOUBLE = javaType5;
        androidx.datastore.preferences.protobuf.JavaType javaType6 = new androidx.datastore.preferences.protobuf.JavaType("BOOLEAN", 5, java.lang.bool.TYPE, java.lang.bool.class, false);
        BOOLEAN = javaType6;
        androidx.datastore.preferences.protobuf.JavaType javaType7 = new androidx.datastore.preferences.protobuf.JavaType("STRING", 6, java.lang.string.class, java.lang.string.class, "");
        STRING = javaType7;
        androidx.datastore.preferences.protobuf.JavaType javaType8 = new androidx.datastore.preferences.protobuf.JavaType("BYTE_STRING", 7, androidx.datastore.preferences.protobuf.bytestring.class, androidx.datastore.preferences.protobuf.bytestring.class, androidx.datastore.preferences.protobuf.bytestring.EMPTY);
        BYTE_STRING = javaType8;
        androidx.datastore.preferences.protobuf.JavaType javaType9 = new androidx.datastore.preferences.protobuf.JavaType("ENUM", 8, java.lang.int.TYPE, java.lang.int.class, null);
        ENUM = javaType9;
        androidx.datastore.preferences.protobuf.JavaType javaType10 = new androidx.datastore.preferences.protobuf.JavaType("MESSAGE", 9, java.lang.object.class, java.lang.object.class, null);
        MESSAGE = javaType10;
        $VALUES = new androidx.datastore.preferences.protobuf.JavaType[]{javaType, javaType2, javaType3, javaType4, javaType5, javaType6, javaType7, javaType8, javaType9, javaType10};
    }

    private JavaType(java.lang.string str, int i, java.lang.Class cls, java.lang.Class cls2, java.lang.object obj) {
        super(str, i);
        this.type = cls;
        this.boxedType = cls2;
        this.defaultDefault = obj;
    }

    public static androidx.datastore.preferences.protobuf.JavaType ValueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.JavaType) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.JavaType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.JavaType[] Values() {
        return (androidx.datastore.preferences.protobuf.JavaType[]) $VALUES.clone();
    }

    public java.lang.Class<object> GetBoxedType() {
        return this.boxedType;
    }

    public java.lang.object GetDefaultDefault() {
        return this.defaultDefault;
    }

    public java.lang.Class<object> GetType() {
        return this.type;
    }

    public bool IsValidType(java.lang.Class<object> cls) {
        return this.type.isAssignableFrom(cls);
    }
}

