namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSet$JsonFormat : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat ALLOW;
    public static readonly int ALLOW_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat JSON_FORMAT_UNKNOWN;
    public static readonly int JSON_FORMAT_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat LEGACY_BEST_EFFORT;
    public static readonly int LEGACY_BEST_EFFORT_VALUE = 2;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat> internalValueDictionary;
    private readonly int value;

    static {
        if ((6 + 11) % 11 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat descriptorProtos$FeatureHashSet$JsonFormat = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat("JSON_FORMAT_UNKNOWN", 0, 0);
        JSON_FORMAT_UNKNOWN = descriptorProtos$FeatureHashSet$JsonFormat;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat descriptorProtos$FeatureHashSet$JsonFormat2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat("ALLOW", 1, 1);
        ALLOW = descriptorProtos$FeatureHashSet$JsonFormat2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat descriptorProtos$FeatureHashSet$JsonFormat3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat("LEGACY_BEST_EFFORT", 2, 2);
        LEGACY_BEST_EFFORT = descriptorProtos$FeatureHashSet$JsonFormat3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat[]{descriptorProtos$FeatureHashSet$JsonFormat, descriptorProtos$FeatureHashSet$JsonFormat2, descriptorProtos$FeatureHashSet$JsonFormat3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat$1();
    }

    private DescriptorProtos$FeatureHashSet$JsonFormat(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat forNumber(int i) {
        if (i == 0) {
            return JSON_FORMAT_UNKNOWN;
        }
        if (i == 1) {
            return ALLOW;
        }
        if (i == 2) {
            return LEGACY_BEST_EFFORT;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat$JsonFormatVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

