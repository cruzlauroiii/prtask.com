namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldOptions$CType : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType CORD;
    public static readonly int CORD_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType STRING;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType STRING_PIECE;
    public static readonly int STRING_PIECE_VALUE = 2;
    public static readonly int STRING_VALUE = 0;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType> internalValueDictionary;
    private readonly int value;

    static {
        if ((12 + 22) % 22 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType descriptorProtos$FieldOptions$CType = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType("STRING", 0, 0);
        STRING = descriptorProtos$FieldOptions$CType;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType descriptorProtos$FieldOptions$CType2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType("CORD", 1, 1);
        CORD = descriptorProtos$FieldOptions$CType2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType descriptorProtos$FieldOptions$CType3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType("STRING_PIECE", 2, 2);
        STRING_PIECE = descriptorProtos$FieldOptions$CType3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType[]{descriptorProtos$FieldOptions$CType, descriptorProtos$FieldOptions$CType2, descriptorProtos$FieldOptions$CType3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType$1();
    }

    private DescriptorProtos$FieldOptions$CType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType forNumber(int i) {
        if (i == 0) {
            return STRING;
        }
        if (i == 1) {
            return CORD;
        }
        if (i == 2) {
            return STRING_PIECE;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType$CTypeVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

