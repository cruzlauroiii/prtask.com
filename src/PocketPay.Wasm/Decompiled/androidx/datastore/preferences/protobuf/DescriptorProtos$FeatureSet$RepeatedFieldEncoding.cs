namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding EXPANDED;
    public static readonly int EXPANDED_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding PACKED;
    public static readonly int PACKED_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding REPEATED_FIELD_ENCODING_UNKNOWN;
    public static readonly int REPEATED_FIELD_ENCODING_UNKNOWN_VALUE = 0;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding> internalValueDictionary;
    private readonly int value;

    static {
        if ((28 + 23) % 23 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding descriptorProtos$FeatureHashSet$RepeatedFieldEncoding = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding("REPEATED_FIELD_ENCODING_UNKNOWN", 0, 0);
        REPEATED_FIELD_ENCODING_UNKNOWN = descriptorProtos$FeatureHashSet$RepeatedFieldEncoding;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding descriptorProtos$FeatureHashSet$RepeatedFieldEncoding2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding("PACKED", 1, 1);
        PACKED = descriptorProtos$FeatureHashSet$RepeatedFieldEncoding2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding descriptorProtos$FeatureHashSet$RepeatedFieldEncoding3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding("EXPANDED", 2, 2);
        EXPANDED = descriptorProtos$FeatureHashSet$RepeatedFieldEncoding3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding[]{descriptorProtos$FeatureHashSet$RepeatedFieldEncoding, descriptorProtos$FeatureHashSet$RepeatedFieldEncoding2, descriptorProtos$FeatureHashSet$RepeatedFieldEncoding3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding$1();
    }

    private DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding forNumber(int i) {
        if (i == 0) {
            return REPEATED_FIELD_ENCODING_UNKNOWN;
        }
        if (i == 1) {
            return PACKED;
        }
        if (i == 2) {
            return EXPANDED;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0072x7f8b7fea.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

