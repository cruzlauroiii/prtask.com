namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSet$MessageEncoding : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding DELIMITED;
    public static readonly int DELIMITED_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding LENGTH_PREFIXED;
    public static readonly int LENGTH_PREFIXED_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding MESSAGE_ENCODING_UNKNOWN;
    public static readonly int MESSAGE_ENCODING_UNKNOWN_VALUE = 0;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding> internalValueDictionary;
    private readonly int value;

    static {
        if ((27 + 3) % 3 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding descriptorProtos$FeatureHashSet$MessageEncoding = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding("MESSAGE_ENCODING_UNKNOWN", 0, 0);
        MESSAGE_ENCODING_UNKNOWN = descriptorProtos$FeatureHashSet$MessageEncoding;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding descriptorProtos$FeatureHashSet$MessageEncoding2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding("LENGTH_PREFIXED", 1, 1);
        LENGTH_PREFIXED = descriptorProtos$FeatureHashSet$MessageEncoding2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding descriptorProtos$FeatureHashSet$MessageEncoding3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding("DELIMITED", 2, 2);
        DELIMITED = descriptorProtos$FeatureHashSet$MessageEncoding3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding[]{descriptorProtos$FeatureHashSet$MessageEncoding, descriptorProtos$FeatureHashSet$MessageEncoding2, descriptorProtos$FeatureHashSet$MessageEncoding3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding$1();
    }

    private DescriptorProtos$FeatureHashSet$MessageEncoding(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding forNumber(int i) {
        if (i == 0) {
            return MESSAGE_ENCODING_UNKNOWN;
        }
        if (i == 1) {
            return LENGTH_PREFIXED;
        }
        if (i == 2) {
            return DELIMITED;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0071x1aaffcf8.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

