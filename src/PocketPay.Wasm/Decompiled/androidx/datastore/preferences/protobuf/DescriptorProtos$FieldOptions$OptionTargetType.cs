namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldOptions$OptionTargetType : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_ENUM;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_ENUM_ENTRY;
    public static readonly int TARGET_TYPE_ENUM_ENTRY_VALUE = 7;
    public static readonly int TARGET_TYPE_ENUM_VALUE = 6;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_EXTENSION_RANGE;
    public static readonly int TARGET_TYPE_EXTENSION_RANGE_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_FIELD;
    public static readonly int TARGET_TYPE_FIELD_VALUE = 4;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_FILE;
    public static readonly int TARGET_TYPE_FILE_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_MESSAGE;
    public static readonly int TARGET_TYPE_MESSAGE_VALUE = 3;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_METHOD;
    public static readonly int TARGET_TYPE_METHOD_VALUE = 9;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_ONEOF;
    public static readonly int TARGET_TYPE_ONEOF_VALUE = 5;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_SERVICE;
    public static readonly int TARGET_TYPE_SERVICE_VALUE = 8;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType TARGET_TYPE_UNKNOWN;
    public static readonly int TARGET_TYPE_UNKNOWN_VALUE = 0;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> internalValueDictionary;
    private readonly int value;

    static {
        if ((7 + 8) % 8 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_UNKNOWN", 0, 0);
        TARGET_TYPE_UNKNOWN = descriptorProtos$FieldOptions$OptionTargetType;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_FILE", 1, 1);
        TARGET_TYPE_FILE = descriptorProtos$FieldOptions$OptionTargetType2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_EXTENSION_RANGE", 2, 2);
        TARGET_TYPE_EXTENSION_RANGE = descriptorProtos$FieldOptions$OptionTargetType3;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType4 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_MESSAGE", 3, 3);
        TARGET_TYPE_MESSAGE = descriptorProtos$FieldOptions$OptionTargetType4;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType5 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_FIELD", 4, 4);
        TARGET_TYPE_FIELD = descriptorProtos$FieldOptions$OptionTargetType5;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType6 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_ONEOF", 5, 5);
        TARGET_TYPE_ONEOF = descriptorProtos$FieldOptions$OptionTargetType6;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType7 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_ENUM", 6, 6);
        TARGET_TYPE_ENUM = descriptorProtos$FieldOptions$OptionTargetType7;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType8 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_ENUM_ENTRY", 7, 7);
        TARGET_TYPE_ENUM_ENTRY = descriptorProtos$FieldOptions$OptionTargetType8;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType9 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_SERVICE", 8, 8);
        TARGET_TYPE_SERVICE = descriptorProtos$FieldOptions$OptionTargetType9;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType10 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType("TARGET_TYPE_METHOD", 9, 9);
        TARGET_TYPE_METHOD = descriptorProtos$FieldOptions$OptionTargetType10;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType[]{descriptorProtos$FieldOptions$OptionTargetType, descriptorProtos$FieldOptions$OptionTargetType2, descriptorProtos$FieldOptions$OptionTargetType3, descriptorProtos$FieldOptions$OptionTargetType4, descriptorProtos$FieldOptions$OptionTargetType5, descriptorProtos$FieldOptions$OptionTargetType6, descriptorProtos$FieldOptions$OptionTargetType7, descriptorProtos$FieldOptions$OptionTargetType8, descriptorProtos$FieldOptions$OptionTargetType9, descriptorProtos$FieldOptions$OptionTargetType10};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType$1();
    }

    private DescriptorProtos$FieldOptions$OptionTargetType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType forNumber(int i) {
        switch (i) {
            case 0:
                return TARGET_TYPE_UNKNOWN;
            case 1:
                return TARGET_TYPE_FILE;
            case 2:
                return TARGET_TYPE_EXTENSION_RANGE;
            case 3:
                return TARGET_TYPE_MESSAGE;
            case 4:
                return TARGET_TYPE_FIELD;
            case 5:
                return TARGET_TYPE_ONEOF;
            case 6:
                return TARGET_TYPE_ENUM;
            case 7:
                return TARGET_TYPE_ENUM_ENTRY;
            case 8:
                return TARGET_TYPE_SERVICE;
            case 9:
                return TARGET_TYPE_METHOD;
            default:
                return null;
        }
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0077xe48a76c4.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

