namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSet$Utf8Validation : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation NONE;
    public static readonly int NONE_VALUE = 3;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation UTF8_VALIDATION_UNKNOWN;
    public static readonly int UTF8_VALIDATION_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation VERIFY;
    public static readonly int VERIFY_VALUE = 2;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation> internalValueDictionary;
    private readonly int value;

    static {
        if ((27 + 4) % 4 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation descriptorProtos$FeatureHashSet$Utf8Validation = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation("UTF8_VALIDATION_UNKNOWN", 0, 0);
        UTF8_VALIDATION_UNKNOWN = descriptorProtos$FeatureHashSet$Utf8Validation;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation descriptorProtos$FeatureHashSet$Utf8Validation2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation("VERIFY", 1, 2);
        VERIFY = descriptorProtos$FeatureHashSet$Utf8Validation2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation descriptorProtos$FeatureHashSet$Utf8Validation3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation("NONE", 2, 3);
        NONE = descriptorProtos$FeatureHashSet$Utf8Validation3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation[]{descriptorProtos$FeatureHashSet$Utf8Validation, descriptorProtos$FeatureHashSet$Utf8Validation2, descriptorProtos$FeatureHashSet$Utf8Validation3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation$1();
    }

    private DescriptorProtos$FeatureHashSet$Utf8Validation(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation forNumber(int i) {
        if (i == 0) {
            return UTF8_VALIDATION_UNKNOWN;
        }
        if (i == 2) {
            return VERIFY;
        }
        if (i == 3) {
            return NONE;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0073xaf44d94c.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

