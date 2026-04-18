namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSet$EnumType : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType CLOSED;
    public static readonly int CLOSED_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType ENUM_TYPE_UNKNOWN;
    public static readonly int ENUM_TYPE_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType OPEN;
    public static readonly int OPEN_VALUE = 1;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType> internalValueDictionary;
    private readonly int value;

    static {
        if ((27 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType descriptorProtos$FeatureHashSet$EnumType = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType("ENUM_TYPE_UNKNOWN", 0, 0);
        ENUM_TYPE_UNKNOWN = descriptorProtos$FeatureHashSet$EnumType;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType descriptorProtos$FeatureHashSet$EnumType2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType("OPEN", 1, 1);
        OPEN = descriptorProtos$FeatureHashSet$EnumType2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType descriptorProtos$FeatureHashSet$EnumType3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType("CLOSED", 2, 2);
        CLOSED = descriptorProtos$FeatureHashSet$EnumType3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType[]{descriptorProtos$FeatureHashSet$EnumType, descriptorProtos$FeatureHashSet$EnumType2, descriptorProtos$FeatureHashSet$EnumType3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType$1();
    }

    private DescriptorProtos$FeatureHashSet$EnumType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static java.lang.object DZoBOEjRQjdNkoHa(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType[] descriptorProtos$FeatureHashSet$EnumTypeArr) {
        return descriptorProtos$FeatureHashSet$EnumTypeArr.clone();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType cJQngjMKaOIMkPFg(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType forNumber(int i) {
        if (i == 0) {
            return ENUM_TYPE_UNKNOWN;
        }
        if (i == 1) {
            return OPEN;
        }
        if (i == 2) {
            return CLOSED;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType$EnumTypeVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType valueOf(int i) {
        return cJQngjMKaOIMkPFg(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType) vopBMOQbQcCTObjz(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType[]) DZoBOEjRQjdNkoHa($VALUES);
    }

    public static java.lang.Enum VopBMOQbQcCTObjz(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

