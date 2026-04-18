namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldOptions$OptionRetention : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention RETENTION_RUNTIME;
    public static readonly int RETENTION_RUNTIME_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention RETENTION_SOURCE;
    public static readonly int RETENTION_SOURCE_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention RETENTION_UNKNOWN;
    public static readonly int RETENTION_UNKNOWN_VALUE = 0;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention> internalValueDictionary;
    private readonly int value;

    static {
        if ((1 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention descriptorProtos$FieldOptions$OptionRetention = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention("RETENTION_UNKNOWN", 0, 0);
        RETENTION_UNKNOWN = descriptorProtos$FieldOptions$OptionRetention;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention descriptorProtos$FieldOptions$OptionRetention2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention("RETENTION_RUNTIME", 1, 1);
        RETENTION_RUNTIME = descriptorProtos$FieldOptions$OptionRetention2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention descriptorProtos$FieldOptions$OptionRetention3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention("RETENTION_SOURCE", 2, 2);
        RETENTION_SOURCE = descriptorProtos$FieldOptions$OptionRetention3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention[]{descriptorProtos$FieldOptions$OptionRetention, descriptorProtos$FieldOptions$OptionRetention2, descriptorProtos$FieldOptions$OptionRetention3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention$1();
    }

    private DescriptorProtos$FieldOptions$OptionRetention(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention forNumber(int i) {
        if (i == 0) {
            return RETENTION_UNKNOWN;
        }
        if (i == 1) {
            return RETENTION_RUNTIME;
        }
        if (i == 2) {
            return RETENTION_SOURCE;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0076x40db608e.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

