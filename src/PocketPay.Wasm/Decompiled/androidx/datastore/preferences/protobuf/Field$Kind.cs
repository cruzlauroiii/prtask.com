namespace WillowMaze.Wasm.Decompiled;


public readonly class Field$Kind : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.Field$Kind[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_BOOL;
    public static readonly int TYPE_BOOL_VALUE = 8;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_BYTES;
    public static readonly int TYPE_BYTES_VALUE = 12;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_DOUBLE;
    public static readonly int TYPE_DOUBLE_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_ENUM;
    public static readonly int TYPE_ENUM_VALUE = 14;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_FIXED32;
    public static readonly int TYPE_FIXED32_VALUE = 7;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_FIXED64;
    public static readonly int TYPE_FIXED64_VALUE = 6;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_FLOAT;
    public static readonly int TYPE_FLOAT_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_GROUP;
    public static readonly int TYPE_GROUP_VALUE = 10;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_INT32;
    public static readonly int TYPE_INT32_VALUE = 5;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_INT64;
    public static readonly int TYPE_INT64_VALUE = 3;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_MESSAGE;
    public static readonly int TYPE_MESSAGE_VALUE = 11;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_SFIXED32;
    public static readonly int TYPE_SFIXED32_VALUE = 15;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_SFIXED64;
    public static readonly int TYPE_SFIXED64_VALUE = 16;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_SINT32;
    public static readonly int TYPE_SINT32_VALUE = 17;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_SINT64;
    public static readonly int TYPE_SINT64_VALUE = 18;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_STRING;
    public static readonly int TYPE_STRING_VALUE = 9;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_UINT32;
    public static readonly int TYPE_UINT32_VALUE = 13;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_UINT64;
    public static readonly int TYPE_UINT64_VALUE = 4;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind TYPE_UNKNOWN;
    public static readonly int TYPE_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.Field$Kind UNRECOGNIZED;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.Field$Kind> internalValueDictionary;
    private readonly int value;

    static {
        if ((8 + 17) % 17 > 0) {
        }
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_UNKNOWN", 0, 0);
        TYPE_UNKNOWN = field$Kind;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind2 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_DOUBLE", 1, 1);
        TYPE_DOUBLE = field$Kind2;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind3 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_FLOAT", 2, 2);
        TYPE_FLOAT = field$Kind3;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind4 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_INT64", 3, 3);
        TYPE_INT64 = field$Kind4;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind5 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_UINT64", 4, 4);
        TYPE_UINT64 = field$Kind5;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind6 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_INT32", 5, 5);
        TYPE_INT32 = field$Kind6;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind7 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_FIXED64", 6, 6);
        TYPE_FIXED64 = field$Kind7;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind8 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_FIXED32", 7, 7);
        TYPE_FIXED32 = field$Kind8;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind9 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_BOOL", 8, 8);
        TYPE_BOOL = field$Kind9;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind10 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_STRING", 9, 9);
        TYPE_STRING = field$Kind10;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind11 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_GROUP", 10, 10);
        TYPE_GROUP = field$Kind11;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind12 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_MESSAGE", 11, 11);
        TYPE_MESSAGE = field$Kind12;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind13 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_BYTES", 12, 12);
        TYPE_BYTES = field$Kind13;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind14 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_UINT32", 13, 13);
        TYPE_UINT32 = field$Kind14;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind15 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_ENUM", 14, 14);
        TYPE_ENUM = field$Kind15;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind16 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_SFIXED32", 15, 15);
        TYPE_SFIXED32 = field$Kind16;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind17 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_SFIXED64", 16, 16);
        TYPE_SFIXED64 = field$Kind17;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind18 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_SINT32", 17, 17);
        TYPE_SINT32 = field$Kind18;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind19 = new androidx.datastore.preferences.protobuf.Field$Kind("TYPE_SINT64", 18, 18);
        TYPE_SINT64 = field$Kind19;
        androidx.datastore.preferences.protobuf.Field$Kind field$Kind20 = new androidx.datastore.preferences.protobuf.Field$Kind("UNRECOGNIZED", 19, -1);
        UNRECOGNIZED = field$Kind20;
        $VALUES = new androidx.datastore.preferences.protobuf.Field$Kind[]{field$Kind, field$Kind2, field$Kind3, field$Kind4, field$Kind5, field$Kind6, field$Kind7, field$Kind8, field$Kind9, field$Kind10, field$Kind11, field$Kind12, field$Kind13, field$Kind14, field$Kind15, field$Kind16, field$Kind17, field$Kind18, field$Kind19, field$Kind20};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.Field$Kind$1();
    }

    private Field$Kind(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.Field$Kind forNumber(int i) {
        switch (i) {
            case 0:
                return TYPE_UNKNOWN;
            case 1:
                return TYPE_DOUBLE;
            case 2:
                return TYPE_FLOAT;
            case 3:
                return TYPE_INT64;
            case 4:
                return TYPE_UINT64;
            case 5:
                return TYPE_INT32;
            case 6:
                return TYPE_FIXED64;
            case 7:
                return TYPE_FIXED32;
            case 8:
                return TYPE_BOOL;
            case 9:
                return TYPE_STRING;
            case 10:
                return TYPE_GROUP;
            case 11:
                return TYPE_MESSAGE;
            case 12:
                return TYPE_BYTES;
            case 13:
                return TYPE_UINT32;
            case 14:
                return TYPE_ENUM;
            case 15:
                return TYPE_SFIXED32;
            case 16:
                return TYPE_SFIXED64;
            case 17:
                return TYPE_SINT32;
            case 18:
                return TYPE_SINT64;
            default:
                return null;
        }
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.Field$Kind> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.Field$Kind$KindVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.Field$Kind valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.Field$Kind valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.Field$Kind) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.Field$Kind.class, str);
    }

    public static androidx.datastore.preferences.protobuf.Field$Kind[] values() {
        return (androidx.datastore.preferences.protobuf.Field$Kind[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        if (this == UNRECOGNIZED) {
            throw new java.lang.IllegalArgumentException("Can't get the number of an unknown enum value.");
        }
        return this.value;
    }
}

