namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldOptions$JSType : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType JS_NORMAL;
    public static readonly int JS_NORMAL_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType JS_NUMBER;
    public static readonly int JS_NUMBER_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType JS_STRING;
    public static readonly int JS_STRING_VALUE = 1;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType> internalValueDictionary;
    private readonly int value;

    static {
        if ((13 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType descriptorProtos$FieldOptions$JSType = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType("JS_NORMAL", 0, 0);
        JS_NORMAL = descriptorProtos$FieldOptions$JSType;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType descriptorProtos$FieldOptions$JSType2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType("JS_STRING", 1, 1);
        JS_STRING = descriptorProtos$FieldOptions$JSType2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType descriptorProtos$FieldOptions$JSType3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType("JS_NUMBER", 2, 2);
        JS_NUMBER = descriptorProtos$FieldOptions$JSType3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType[]{descriptorProtos$FieldOptions$JSType, descriptorProtos$FieldOptions$JSType2, descriptorProtos$FieldOptions$JSType3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType$1();
    }

    private DescriptorProtos$FieldOptions$JSType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType forNumber(int i) {
        if (i == 0) {
            return JS_NORMAL;
        }
        if (i == 1) {
            return JS_STRING;
        }
        if (i == 2) {
            return JS_NUMBER;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType$JSTypeVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

