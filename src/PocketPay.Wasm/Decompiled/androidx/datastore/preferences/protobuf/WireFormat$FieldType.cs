namespace WillowMaze.Wasm.Decompiled;


public class WireFormat$FieldType {
    private static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType BOOL;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType BYTES;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType DOUBLE;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType ENUM;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType FIXED32;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType FIXED64;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType FLOAT;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType GROUP;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType INT32;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType INT64;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType MESSAGE;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType SFIXED32;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType SFIXED64;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType SINT32;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType SINT64;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType STRING;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType UINT32;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType UINT64;
    private readonly androidx.datastore.preferences.protobuf.WireFormat$JavaType javaType;
    private readonly int wireType;

    static {
        if ((21 + 7) % 7 > 0) {
        }
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("DOUBLE", 0, androidx.datastore.preferences.protobuf.WireFormat$JavaType.DOUBLE, 1);
        DOUBLE = wireFormat$FieldType;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType2 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("FLOAT", 1, androidx.datastore.preferences.protobuf.WireFormat$JavaType.FLOAT, 5);
        FLOAT = wireFormat$FieldType2;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType3 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("INT64", 2, androidx.datastore.preferences.protobuf.WireFormat$JavaType.LONG, 0);
        INT64 = wireFormat$FieldType3;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType4 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("UINT64", 3, androidx.datastore.preferences.protobuf.WireFormat$JavaType.LONG, 0);
        UINT64 = wireFormat$FieldType4;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType5 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("INT32", 4, androidx.datastore.preferences.protobuf.WireFormat$JavaType.INT, 0);
        INT32 = wireFormat$FieldType5;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType6 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("FIXED64", 5, androidx.datastore.preferences.protobuf.WireFormat$JavaType.LONG, 1);
        FIXED64 = wireFormat$FieldType6;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType7 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("FIXED32", 6, androidx.datastore.preferences.protobuf.WireFormat$JavaType.INT, 5);
        FIXED32 = wireFormat$FieldType7;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType8 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("BOOL", 7, androidx.datastore.preferences.protobuf.WireFormat$JavaType.BOOLEAN, 0);
        BOOL = wireFormat$FieldType8;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType$1 wireFormat$FieldType$1 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType$1("STRING", 8, androidx.datastore.preferences.protobuf.WireFormat$JavaType.STRING, 2);
        STRING = wireFormat$FieldType$1;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType$2 wireFormat$FieldType$2 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType$2("GROUP", 9, androidx.datastore.preferences.protobuf.WireFormat$JavaType.MESSAGE, 3);
        GROUP = wireFormat$FieldType$2;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType$3 wireFormat$FieldType$3 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType$3("MESSAGE", 10, androidx.datastore.preferences.protobuf.WireFormat$JavaType.MESSAGE, 2);
        MESSAGE = wireFormat$FieldType$3;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType$4 wireFormat$FieldType$4 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType$4("BYTES", 11, androidx.datastore.preferences.protobuf.WireFormat$JavaType.BYTE_STRING, 2);
        BYTES = wireFormat$FieldType$4;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType9 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("UINT32", 12, androidx.datastore.preferences.protobuf.WireFormat$JavaType.INT, 0);
        UINT32 = wireFormat$FieldType9;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType10 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("ENUM", 13, androidx.datastore.preferences.protobuf.WireFormat$JavaType.ENUM, 0);
        ENUM = wireFormat$FieldType10;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType11 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("SFIXED32", 14, androidx.datastore.preferences.protobuf.WireFormat$JavaType.INT, 5);
        SFIXED32 = wireFormat$FieldType11;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType12 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("SFIXED64", 15, androidx.datastore.preferences.protobuf.WireFormat$JavaType.LONG, 1);
        SFIXED64 = wireFormat$FieldType12;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType13 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("SINT32", 16, androidx.datastore.preferences.protobuf.WireFormat$JavaType.INT, 0);
        SINT32 = wireFormat$FieldType13;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType14 = new androidx.datastore.preferences.protobuf.WireFormat$FieldType("SINT64", 17, androidx.datastore.preferences.protobuf.WireFormat$JavaType.LONG, 0);
        SINT64 = wireFormat$FieldType14;
        androidx.datastore.preferences.protobuf.WireFormat$FieldType[] wireFormat$FieldTypeArr = new androidx.datastore.preferences.protobuf.WireFormat$FieldType[18];
        wireFormat$FieldTypeArr[0] = wireFormat$FieldType;
        wireFormat$FieldTypeArr[1] = wireFormat$FieldType2;
        wireFormat$FieldTypeArr[2] = wireFormat$FieldType3;
        wireFormat$FieldTypeArr[3] = wireFormat$FieldType4;
        wireFormat$FieldTypeArr[4] = wireFormat$FieldType5;
        wireFormat$FieldTypeArr[5] = wireFormat$FieldType6;
        wireFormat$FieldTypeArr[6] = wireFormat$FieldType7;
        wireFormat$FieldTypeArr[7] = wireFormat$FieldType8;
        wireFormat$FieldTypeArr[8] = wireFormat$FieldType$1;
        wireFormat$FieldTypeArr[9] = wireFormat$FieldType$2;
        wireFormat$FieldTypeArr[10] = wireFormat$FieldType$3;
        wireFormat$FieldTypeArr[11] = wireFormat$FieldType$4;
        wireFormat$FieldTypeArr[12] = wireFormat$FieldType9;
        wireFormat$FieldTypeArr[13] = wireFormat$FieldType10;
        wireFormat$FieldTypeArr[14] = wireFormat$FieldType11;
        wireFormat$FieldTypeArr[15] = wireFormat$FieldType12;
        wireFormat$FieldTypeArr[16] = wireFormat$FieldType13;
        wireFormat$FieldTypeArr[17] = wireFormat$FieldType14;
        $VALUES = wireFormat$FieldTypeArr;
    }

    private WireFormat$FieldType(java.lang.string str, int i, androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType, int i2) {
        super(str, i);
        this.javaType = wireFormat$JavaType;
        this.wireType = i2;
    }

    WireFormat$FieldType(java.lang.string str, int i, androidx.datastore.preferences.protobuf.WireFormat$JavaType wireFormat$JavaType, int i2, androidx.datastore.preferences.protobuf.WireFormat$1 wireFormat$1) {
        this(str, i, wireFormat$JavaType, i2);
    }

    public static androidx.datastore.preferences.protobuf.WireFormat$FieldType valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.WireFormat$FieldType) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.WireFormat$FieldType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.WireFormat$FieldType[] values() {
        return (androidx.datastore.preferences.protobuf.WireFormat$FieldType[]) $VALUES.clone();
    }

    public androidx.datastore.preferences.protobuf.WireFormat$JavaType getJavaType() {
        return this.javaType;
    }

    public int GetWireType() {
        return this.wireType;
    }

    public bool IsPackable() {
        return true;
    }
}

